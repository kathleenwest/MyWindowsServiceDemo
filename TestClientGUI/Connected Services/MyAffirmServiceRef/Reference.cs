﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClientGUI.MyAffirmServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyAffirmServiceRef.IAffirmationService")]
    public interface IAffirmationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffirmationService/AffirmMe", ReplyAction="http://tempuri.org/IAffirmationService/AffirmMeResponse")]
        string AffirmMe(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAffirmationService/AffirmMe", ReplyAction="http://tempuri.org/IAffirmationService/AffirmMeResponse")]
        System.Threading.Tasks.Task<string> AffirmMeAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAffirmationServiceChannel : TestClientGUI.MyAffirmServiceRef.IAffirmationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AffirmationServiceClient : System.ServiceModel.ClientBase<TestClientGUI.MyAffirmServiceRef.IAffirmationService>, TestClientGUI.MyAffirmServiceRef.IAffirmationService {
        
        public AffirmationServiceClient() {
        }
        
        public AffirmationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AffirmationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AffirmationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AffirmationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AffirmMe(string name) {
            return base.Channel.AffirmMe(name);
        }
        
        public System.Threading.Tasks.Task<string> AffirmMeAsync(string name) {
            return base.Channel.AffirmMeAsync(name);
        }
    }
}
