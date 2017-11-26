﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distributor.WCFMusicStreamManagerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Music", Namespace="http://schemas.datacontract.org/2004/07/WCFMusicStreamingServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Music : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlbumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AvaiableToStreamingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Album {
            get {
                return this.AlbumField;
            }
            set {
                if ((object.ReferenceEquals(this.AlbumField, value) != true)) {
                    this.AlbumField = value;
                    this.RaisePropertyChanged("Album");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Artist {
            get {
                return this.ArtistField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistField, value) != true)) {
                    this.ArtistField = value;
                    this.RaisePropertyChanged("Artist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AvaiableToStreaming {
            get {
                return this.AvaiableToStreamingField;
            }
            set {
                if ((this.AvaiableToStreamingField.Equals(value) != true)) {
                    this.AvaiableToStreamingField = value;
                    this.RaisePropertyChanged("AvaiableToStreaming");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time {
            get {
                return this.TimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TimeField, value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFMusicStreamManagerService.IMusicStreamingManagerService")]
    public interface IMusicStreamingManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/AddMusic", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/AddMusicResponse")]
        bool AddMusic(string name, string time, string artist, string album);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/AddMusic", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/AddMusicResponse")]
        System.Threading.Tasks.Task<bool> AddMusicAsync(string name, string time, string artist, string album);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/GetAllMusics", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/GetAllMusicsResponse")]
        Distributor.WCFMusicStreamManagerService.Music[] GetAllMusics();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/GetAllMusics", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/GetAllMusicsResponse")]
        System.Threading.Tasks.Task<Distributor.WCFMusicStreamManagerService.Music[]> GetAllMusicsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/UpdateToStream", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/UpdateToStreamResponse")]
        bool UpdateToStream(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingManagerService/UpdateToStream", ReplyAction="http://tempuri.org/IMusicStreamingManagerService/UpdateToStreamResponse")]
        System.Threading.Tasks.Task<bool> UpdateToStreamAsync(System.Guid id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMusicStreamingManagerServiceChannel : Distributor.WCFMusicStreamManagerService.IMusicStreamingManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusicStreamingManagerServiceClient : System.ServiceModel.ClientBase<Distributor.WCFMusicStreamManagerService.IMusicStreamingManagerService>, Distributor.WCFMusicStreamManagerService.IMusicStreamingManagerService {
        
        public MusicStreamingManagerServiceClient() {
        }
        
        public MusicStreamingManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusicStreamingManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicStreamingManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicStreamingManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddMusic(string name, string time, string artist, string album) {
            return base.Channel.AddMusic(name, time, artist, album);
        }
        
        public System.Threading.Tasks.Task<bool> AddMusicAsync(string name, string time, string artist, string album) {
            return base.Channel.AddMusicAsync(name, time, artist, album);
        }
        
        public Distributor.WCFMusicStreamManagerService.Music[] GetAllMusics() {
            return base.Channel.GetAllMusics();
        }
        
        public System.Threading.Tasks.Task<Distributor.WCFMusicStreamManagerService.Music[]> GetAllMusicsAsync() {
            return base.Channel.GetAllMusicsAsync();
        }
        
        public bool UpdateToStream(System.Guid id) {
            return base.Channel.UpdateToStream(id);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateToStreamAsync(System.Guid id) {
            return base.Channel.UpdateToStreamAsync(id);
        }
    }
}
