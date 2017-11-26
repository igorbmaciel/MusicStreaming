using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFMusicStreamingServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IMusicStreamingService" in both code and config file together.
    public class MusicStreamingService : IMusicStreamingService
    {
        public Music UploadMusic(string name, string time, string artist, string album)
        {
            return new Music(name, time, artist, album);
        }
    }
}
