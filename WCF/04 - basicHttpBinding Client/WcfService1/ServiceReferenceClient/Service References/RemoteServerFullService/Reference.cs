﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceClient.RemoteServerFullService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteServerFullService.IFullService")]
    public interface IFullService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFullService/GetData", ReplyAction="http://tempuri.org/IFullService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFullService/GetData", ReplyAction="http://tempuri.org/IFullService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFullService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFullService/GetDataUsingDataContractResponse")]
        ServiceReferenceClient.RemoteServerFullService.CompositeType GetDataUsingDataContract(ServiceReferenceClient.RemoteServerFullService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFullService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IFullService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceReferenceClient.RemoteServerFullService.CompositeType> GetDataUsingDataContractAsync(ServiceReferenceClient.RemoteServerFullService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFullServiceChannel : ServiceReferenceClient.RemoteServerFullService.IFullService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FullServiceClient : System.ServiceModel.ClientBase<ServiceReferenceClient.RemoteServerFullService.IFullService>, ServiceReferenceClient.RemoteServerFullService.IFullService {
        
        public FullServiceClient() {
        }
        
        public FullServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FullServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FullServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FullServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public ServiceReferenceClient.RemoteServerFullService.CompositeType GetDataUsingDataContract(ServiceReferenceClient.RemoteServerFullService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceClient.RemoteServerFullService.CompositeType> GetDataUsingDataContractAsync(ServiceReferenceClient.RemoteServerFullService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteServerFullService.IServiceMinimized")]
    public interface IServiceMinimized {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceMinimized/GetDataMinimized", ReplyAction="http://tempuri.org/IServiceMinimized/GetDataMinimizedResponse")]
        string GetDataMinimized(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceMinimized/GetDataMinimized", ReplyAction="http://tempuri.org/IServiceMinimized/GetDataMinimizedResponse")]
        System.Threading.Tasks.Task<string> GetDataMinimizedAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceMinimizedChannel : ServiceReferenceClient.RemoteServerFullService.IServiceMinimized, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceMinimizedClient : System.ServiceModel.ClientBase<ServiceReferenceClient.RemoteServerFullService.IServiceMinimized>, ServiceReferenceClient.RemoteServerFullService.IServiceMinimized {
        
        public ServiceMinimizedClient() {
        }
        
        public ServiceMinimizedClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceMinimizedClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceMinimizedClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceMinimizedClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDataMinimized(int value) {
            return base.Channel.GetDataMinimized(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataMinimizedAsync(int value) {
            return base.Channel.GetDataMinimizedAsync(value);
        }
    }
}
