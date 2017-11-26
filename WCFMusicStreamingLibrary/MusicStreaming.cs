using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFMusicStreamingLibrary.MusicStreamingManager;

namespace WCFMusicStreamingLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class MusicStreaming : IMusicStreaming
    {     
        public Music[] GetAvaiableMusics(Music music)
        {
            Music[] musics;
            using (var cli = new MusicStreamingManagerServiceClient())
            {
                cli.Open();
                musics = cli.GetAllMusics()?.Where(t => t.AvaiableToStreaming)?.ToArray();
                cli.Close();
            }

            return musics;
        }

        public bool StreamMusic(Music music)
        {
            bool result = false;
            using (var cli = new MusicStreamingManagerServiceClient())
            {
                cli.Open();
                result = cli.UpdateToStream(music.Id);
                cli.Close();
            }
            return result;
        }
    }
}
