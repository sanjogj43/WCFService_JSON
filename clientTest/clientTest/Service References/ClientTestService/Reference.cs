﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientTest.ClientTestService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientTestService.IInformationService")]
    public interface IInformationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformationService/GetInventoryData", ReplyAction="http://tempuri.org/IInformationService/GetInventoryDataResponse")]
        string GetInventoryData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformationService/GetInventoryData", ReplyAction="http://tempuri.org/IInformationService/GetInventoryDataResponse")]
        System.Threading.Tasks.Task<string> GetInventoryDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInformationServiceChannel : clientTest.ClientTestService.IInformationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InformationServiceClient : System.ServiceModel.ClientBase<clientTest.ClientTestService.IInformationService>, clientTest.ClientTestService.IInformationService {
        
        public InformationServiceClient() {
        }
        
        public InformationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InformationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetInventoryData() {
            return base.Channel.GetInventoryData();
        }
        
        public System.Threading.Tasks.Task<string> GetInventoryDataAsync() {
            return base.Channel.GetInventoryDataAsync();
        }
    }
}
