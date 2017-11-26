using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFMusicStreaming.Model.Exception
{
    [DataContract]
    public class EmptyQueueException
    {
        [DataMember]
        public string Message { get; set; }
        public EmptyQueueException(string message)
        {
            Message = message;
        }
    }
}