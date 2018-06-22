﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test00.testservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenericObject", Namespace="http://schemas.datacontract.org/2004/07/Objects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject>))]
    public partial class GenericObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object MessageField;
        
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
        public object Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="testservice.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        test00.testservice.GenericObject Get(string actor, string attribute);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Get", ReplyAction="http://tempuri.org/IService/GetResponse")]
        System.IAsyncResult BeginGet(string actor, string attribute, System.AsyncCallback callback, object asyncState);
        
        test00.testservice.GenericObject EndGet(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Set", ReplyAction="http://tempuri.org/IService/SetResponse")]
        void Set(string actor, string attribute, test00.testservice.GenericObject value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Set", ReplyAction="http://tempuri.org/IService/SetResponse")]
        System.IAsyncResult BeginSet(string actor, string attribute, test00.testservice.GenericObject value, System.AsyncCallback callback, object asyncState);
        
        void EndSet(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Run", ReplyAction="http://tempuri.org/IService/RunResponse")]
        void Run(string actor, string action, test00.testservice.GenericObject parameters);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/Run", ReplyAction="http://tempuri.org/IService/RunResponse")]
        System.IAsyncResult BeginRun(string actor, string action, test00.testservice.GenericObject parameters, System.AsyncCallback callback, object asyncState);
        
        void EndRun(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllActors", ReplyAction="http://tempuri.org/IService/GetAllActorsResponse")]
        System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> GetAllActors();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService/GetAllActors", ReplyAction="http://tempuri.org/IService/GetAllActorsResponse")]
        System.IAsyncResult BeginGetAllActors(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> EndGetAllActors(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : test00.testservice.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public test00.testservice.GenericObject Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((test00.testservice.GenericObject)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllActorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllActorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<test00.testservice.IService>, test00.testservice.IService {
        
        private BeginOperationDelegate onBeginGetDelegate;
        
        private EndOperationDelegate onEndGetDelegate;
        
        private System.Threading.SendOrPostCallback onGetCompletedDelegate;
        
        private BeginOperationDelegate onBeginSetDelegate;
        
        private EndOperationDelegate onEndSetDelegate;
        
        private System.Threading.SendOrPostCallback onSetCompletedDelegate;
        
        private BeginOperationDelegate onBeginRunDelegate;
        
        private EndOperationDelegate onEndRunDelegate;
        
        private System.Threading.SendOrPostCallback onRunCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllActorsDelegate;
        
        private EndOperationDelegate onEndGetAllActorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllActorsCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetCompletedEventArgs> GetCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SetCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RunCompleted;
        
        public event System.EventHandler<GetAllActorsCompletedEventArgs> GetAllActorsCompleted;
        
        public test00.testservice.GenericObject Get(string actor, string attribute) {
            return base.Channel.Get(actor, attribute);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGet(string actor, string attribute, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGet(actor, attribute, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public test00.testservice.GenericObject EndGet(System.IAsyncResult result) {
            return base.Channel.EndGet(result);
        }
        
        private System.IAsyncResult OnBeginGet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string actor = ((string)(inValues[0]));
            string attribute = ((string)(inValues[1]));
            return this.BeginGet(actor, attribute, callback, asyncState);
        }
        
        private object[] OnEndGet(System.IAsyncResult result) {
            test00.testservice.GenericObject retVal = this.EndGet(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCompleted(object state) {
            if ((this.GetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCompleted(this, new GetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAsync(string actor, string attribute) {
            this.GetAsync(actor, attribute, null);
        }
        
        public void GetAsync(string actor, string attribute, object userState) {
            if ((this.onBeginGetDelegate == null)) {
                this.onBeginGetDelegate = new BeginOperationDelegate(this.OnBeginGet);
            }
            if ((this.onEndGetDelegate == null)) {
                this.onEndGetDelegate = new EndOperationDelegate(this.OnEndGet);
            }
            if ((this.onGetCompletedDelegate == null)) {
                this.onGetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCompleted);
            }
            base.InvokeAsync(this.onBeginGetDelegate, new object[] {
                        actor,
                        attribute}, this.onEndGetDelegate, this.onGetCompletedDelegate, userState);
        }
        
        public void Set(string actor, string attribute, test00.testservice.GenericObject value) {
            base.Channel.Set(actor, attribute, value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSet(string actor, string attribute, test00.testservice.GenericObject value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSet(actor, attribute, value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSet(System.IAsyncResult result) {
            base.Channel.EndSet(result);
        }
        
        private System.IAsyncResult OnBeginSet(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string actor = ((string)(inValues[0]));
            string attribute = ((string)(inValues[1]));
            test00.testservice.GenericObject value = ((test00.testservice.GenericObject)(inValues[2]));
            return this.BeginSet(actor, attribute, value, callback, asyncState);
        }
        
        private object[] OnEndSet(System.IAsyncResult result) {
            this.EndSet(result);
            return null;
        }
        
        private void OnSetCompleted(object state) {
            if ((this.SetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SetCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SetAsync(string actor, string attribute, test00.testservice.GenericObject value) {
            this.SetAsync(actor, attribute, value, null);
        }
        
        public void SetAsync(string actor, string attribute, test00.testservice.GenericObject value, object userState) {
            if ((this.onBeginSetDelegate == null)) {
                this.onBeginSetDelegate = new BeginOperationDelegate(this.OnBeginSet);
            }
            if ((this.onEndSetDelegate == null)) {
                this.onEndSetDelegate = new EndOperationDelegate(this.OnEndSet);
            }
            if ((this.onSetCompletedDelegate == null)) {
                this.onSetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSetCompleted);
            }
            base.InvokeAsync(this.onBeginSetDelegate, new object[] {
                        actor,
                        attribute,
                        value}, this.onEndSetDelegate, this.onSetCompletedDelegate, userState);
        }
        
        public void Run(string actor, string action, test00.testservice.GenericObject parameters) {
            base.Channel.Run(actor, action, parameters);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginRun(string actor, string action, test00.testservice.GenericObject parameters, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRun(actor, action, parameters, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndRun(System.IAsyncResult result) {
            base.Channel.EndRun(result);
        }
        
        private System.IAsyncResult OnBeginRun(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string actor = ((string)(inValues[0]));
            string action = ((string)(inValues[1]));
            test00.testservice.GenericObject parameters = ((test00.testservice.GenericObject)(inValues[2]));
            return this.BeginRun(actor, action, parameters, callback, asyncState);
        }
        
        private object[] OnEndRun(System.IAsyncResult result) {
            this.EndRun(result);
            return null;
        }
        
        private void OnRunCompleted(object state) {
            if ((this.RunCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RunCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RunAsync(string actor, string action, test00.testservice.GenericObject parameters) {
            this.RunAsync(actor, action, parameters, null);
        }
        
        public void RunAsync(string actor, string action, test00.testservice.GenericObject parameters, object userState) {
            if ((this.onBeginRunDelegate == null)) {
                this.onBeginRunDelegate = new BeginOperationDelegate(this.OnBeginRun);
            }
            if ((this.onEndRunDelegate == null)) {
                this.onEndRunDelegate = new EndOperationDelegate(this.OnEndRun);
            }
            if ((this.onRunCompletedDelegate == null)) {
                this.onRunCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRunCompleted);
            }
            base.InvokeAsync(this.onBeginRunDelegate, new object[] {
                        actor,
                        action,
                        parameters}, this.onEndRunDelegate, this.onRunCompletedDelegate, userState);
        }
        
        public System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> GetAllActors() {
            return base.Channel.GetAllActors();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllActors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllActors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> EndGetAllActors(System.IAsyncResult result) {
            return base.Channel.EndGetAllActors(result);
        }
        
        private System.IAsyncResult OnBeginGetAllActors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllActors(callback, asyncState);
        }
        
        private object[] OnEndGetAllActors(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<test00.testservice.GenericObject> retVal = this.EndGetAllActors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllActorsCompleted(object state) {
            if ((this.GetAllActorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllActorsCompleted(this, new GetAllActorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllActorsAsync() {
            this.GetAllActorsAsync(null);
        }
        
        public void GetAllActorsAsync(object userState) {
            if ((this.onBeginGetAllActorsDelegate == null)) {
                this.onBeginGetAllActorsDelegate = new BeginOperationDelegate(this.OnBeginGetAllActors);
            }
            if ((this.onEndGetAllActorsDelegate == null)) {
                this.onEndGetAllActorsDelegate = new EndOperationDelegate(this.OnEndGetAllActors);
            }
            if ((this.onGetAllActorsCompletedDelegate == null)) {
                this.onGetAllActorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllActorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllActorsDelegate, null, this.onEndGetAllActorsDelegate, this.onGetAllActorsCompletedDelegate, userState);
        }
    }
}
