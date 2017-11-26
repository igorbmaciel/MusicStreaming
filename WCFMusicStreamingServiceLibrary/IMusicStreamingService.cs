using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFMusicStreamingServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMusicStreamingService" in both code and config file together.
    [ServiceContract]
    interface IMusicStreamingService
    {
        [OperationContract]
        Music UploadMusic(string name, string time, string artist, string album);
    }    
   
}
