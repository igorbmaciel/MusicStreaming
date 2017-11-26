using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFMusicStreamingManager.MusicStreamingService;

namespace WCFMusicStreamingManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMusicStreamingManagerService" in both code and config file together.
    [ServiceContract]
    public interface IMusicStreamingManagerService
    {
        [OperationContract]
        bool AddMusic(string name, string time, string artist, string album);

        [OperationContract]
        Music[] GetAllMusics();

        [OperationContract]
        bool UpdateToStream(Guid id);
    }
    
}
