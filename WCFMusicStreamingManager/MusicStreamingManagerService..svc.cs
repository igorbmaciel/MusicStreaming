using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFMusicStreamingManager.MusicStreamingService;
using System.Collections.Concurrent;

namespace WCFMusicStreamingManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MusicStreamingManagerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MusicStreamingManagerService.svc or MusicStreamingManagerService.svc.cs at the Solution Explorer and start debugging.
    public class MusicStreamingManagerService : IMusicStreamingManagerService
    {
        private static ConcurrentDictionary<Guid, Music> musics = new ConcurrentDictionary<Guid, Music>();

        public bool AddMusic(string name, string time, string artist, string album)
        {
            Music music;

            using (var cli = new MusicStreamingServiceClient())
            {
                cli.Open();
                music = cli.UploadMusic(name, time, artist, album);
                cli.Close();
            }

            if (music != null)
                return musics.TryAdd(music.Id, music);

            return false;
        }

        public Music[] GetAllMusics()
        {
            return musics.Values.ToArray<Music>();
        }

        public bool UpdateToStream(Guid id)
        {
            Music music;
            music = musics[id];
            music.AvaiableToStreaming = false;

            if (music != null)
                return musics.TryUpdate(id, music, music);

            return false;
        }
    }
}
