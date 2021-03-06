﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopClient.GenericInfoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenericInfo", Namespace="http://schemas.datacontract.org/2004/07/GenericInfo.Data")]
    [System.SerializableAttribute()]
    public partial class GenericInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceNameField;
        
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
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SourceError {
            get {
                return this.SourceErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceErrorField, value) != true)) {
                    this.SourceErrorField = value;
                    this.RaisePropertyChanged("SourceError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SourceName {
            get {
                return this.SourceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceNameField, value) != true)) {
                    this.SourceNameField = value;
                    this.RaisePropertyChanged("SourceName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GenericInfoService.IGenericInfoService")]
    public interface IGenericInfoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetName", ReplyAction="http://tempuri.org/IGenericInfoService/GetNameResponse")]
        string GetName(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetName", ReplyAction="http://tempuri.org/IGenericInfoService/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetInfo", ReplyAction="http://tempuri.org/IGenericInfoService/GetInfoResponse")]
        DesktopClient.GenericInfoService.GenericInfo GetInfo(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetInfo", ReplyAction="http://tempuri.org/IGenericInfoService/GetInfoResponse")]
        System.Threading.Tasks.Task<DesktopClient.GenericInfoService.GenericInfo> GetInfoAsync(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/SetName", ReplyAction="http://tempuri.org/IGenericInfoService/SetNameResponse")]
        void SetName(string sourceName, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/SetName", ReplyAction="http://tempuri.org/IGenericInfoService/SetNameResponse")]
        System.Threading.Tasks.Task SetNameAsync(string sourceName, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/SetInfo", ReplyAction="http://tempuri.org/IGenericInfoService/SetInfoResponse")]
        void SetInfo(string sourceName, DesktopClient.GenericInfoService.GenericInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/SetInfo", ReplyAction="http://tempuri.org/IGenericInfoService/SetInfoResponse")]
        System.Threading.Tasks.Task SetInfoAsync(string sourceName, DesktopClient.GenericInfoService.GenericInfo info);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetRonsQuote", ReplyAction="http://tempuri.org/IGenericInfoService/GetRonsQuoteResponse")]
        string GetRonsQuote(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetRonsQuote", ReplyAction="http://tempuri.org/IGenericInfoService/GetRonsQuoteResponse")]
        System.Threading.Tasks.Task<string> GetRonsQuoteAsync(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetIsUp", ReplyAction="http://tempuri.org/IGenericInfoService/GetIsUpResponse")]
        bool GetIsUp(string sourceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGenericInfoService/GetIsUp", ReplyAction="http://tempuri.org/IGenericInfoService/GetIsUpResponse")]
        System.Threading.Tasks.Task<bool> GetIsUpAsync(string sourceName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGenericInfoServiceChannel : DesktopClient.GenericInfoService.IGenericInfoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GenericInfoServiceClient : System.ServiceModel.ClientBase<DesktopClient.GenericInfoService.IGenericInfoService>, DesktopClient.GenericInfoService.IGenericInfoService {
        
        public GenericInfoServiceClient() {
        }
        
        public GenericInfoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GenericInfoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenericInfoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GenericInfoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetName(string sourceName) {
            return base.Channel.GetName(sourceName);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string sourceName) {
            return base.Channel.GetNameAsync(sourceName);
        }
        
        public DesktopClient.GenericInfoService.GenericInfo GetInfo(string sourceName) {
            return base.Channel.GetInfo(sourceName);
        }
        
        public System.Threading.Tasks.Task<DesktopClient.GenericInfoService.GenericInfo> GetInfoAsync(string sourceName) {
            return base.Channel.GetInfoAsync(sourceName);
        }
        
        public void SetName(string sourceName, string name) {
            base.Channel.SetName(sourceName, name);
        }
        
        public System.Threading.Tasks.Task SetNameAsync(string sourceName, string name) {
            return base.Channel.SetNameAsync(sourceName, name);
        }
        
        public void SetInfo(string sourceName, DesktopClient.GenericInfoService.GenericInfo info) {
            base.Channel.SetInfo(sourceName, info);
        }
        
        public System.Threading.Tasks.Task SetInfoAsync(string sourceName, DesktopClient.GenericInfoService.GenericInfo info) {
            return base.Channel.SetInfoAsync(sourceName, info);
        }
        
        public string GetRonsQuote(string sourceName) {
            return base.Channel.GetRonsQuote(sourceName);
        }
        
        public System.Threading.Tasks.Task<string> GetRonsQuoteAsync(string sourceName) {
            return base.Channel.GetRonsQuoteAsync(sourceName);
        }
        
        public bool GetIsUp(string sourceName) {
            return base.Channel.GetIsUp(sourceName);
        }
        
        public System.Threading.Tasks.Task<bool> GetIsUpAsync(string sourceName) {
            return base.Channel.GetIsUpAsync(sourceName);
        }
    }
}
