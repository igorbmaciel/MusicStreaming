using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WCFMusicStreamingServiceLibrary
{
    [DataContract]
    public class Music
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; } 
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public string Artist { get; set; }
        [DataMember]
        public string Album { get; set; }
        [DataMember]
        public bool AvaiableToStreaming { get; set; }

        public Music(string name, string time, string artist, string album)
        {
            Id = Guid.NewGuid();
            Name = name;
            Time = time;
            Artist = artist;
            Album = album;            
            AvaiableToStreaming = true;
        }
    }
}
