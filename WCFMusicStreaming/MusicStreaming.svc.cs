using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFMusicStreaming.Model.Exception;
using WCFMusicStreaming.MusicStreamingManagerService;

namespace WCFMusicStreaming
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        IncludeExceptionDetailInFaults = true)]
    public class MusicStreaming : IMusicStreaming
    {
        private static readonly ConcurrentQueue<Music> MusicsQueue = new ConcurrentQueue<Music>();

        public Music StreamMusic()
        {
            Music music;
            MusicsQueue.TryDequeue(out music);

            if (music == null && MusicsQueue.Count == 0)
            {
                //throw new FaultException<EmptyQueueException>(new EmptyQueueException("Queue is empty"));
            }


            return music;
        }

        public Music[] GetAvaiableMusics()
        {
            Music[] musics;
            using (var cli = new MusicStreamingManagerServiceClient())
            {
                cli.Open();
                musics = cli.GetAllMusics()?.Where(t => t.AvaiableToStreaming)?.ToArray();
                cli.Close();
            }

            foreach (var music in musics)
            {
                MusicsQueue.Enqueue(music);
            }

            return musics;
        }
    }
}
