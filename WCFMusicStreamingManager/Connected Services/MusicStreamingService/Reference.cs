﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFMusicStreamingManager.MusicStreamingService {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusicStreamingService.IMusicStreamingService")]
    public interface IMusicStreamingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingService/UploadMusic", ReplyAction="http://tempuri.org/IMusicStreamingService/UploadMusicResponse")]
        WCFMusicStreamingManager.MusicStreamingService.Music UploadMusic(string name, string time, string artist, string album);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMusicStreamingService/UploadMusic", ReplyAction="http://tempuri.org/IMusicStreamingService/UploadMusicResponse")]
        System.Threading.Tasks.Task<WCFMusicStreamingManager.MusicStreamingService.Music> UploadMusicAsync(string name, string time, string artist, string album);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMusicStreamingServiceChannel : WCFMusicStreamingManager.MusicStreamingService.IMusicStreamingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusicStreamingServiceClient : System.ServiceModel.ClientBase<WCFMusicStreamingManager.MusicStreamingService.IMusicStreamingService>, WCFMusicStreamingManager.MusicStreamingService.IMusicStreamingService {
        
        public MusicStreamingServiceClient() {
        }
        
        public MusicStreamingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusicStreamingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicStreamingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicStreamingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFMusicStreamingManager.MusicStreamingService.Music UploadMusic(string name, string time, string artist, string album) {
            return base.Channel.UploadMusic(name, time, artist, album);
        }
        
        public System.Threading.Tasks.Task<WCFMusicStreamingManager.MusicStreamingService.Music> UploadMusicAsync(string name, string time, string artist, string album) {
            return base.Channel.UploadMusicAsync(name, time, artist, album);
        }
    }
}
