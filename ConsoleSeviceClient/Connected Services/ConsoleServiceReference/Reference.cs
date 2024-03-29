﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleSeviceClient.ConsoleServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsoleServiceReference.ICurrencyConverterService")]
    public interface ICurrencyConverterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverterService/ConvertToWord", ReplyAction="http://tempuri.org/ICurrencyConverterService/ConvertToWordResponse")]
        string ConvertToWord(decimal usdCurrency);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConverterService/ConvertToWord", ReplyAction="http://tempuri.org/ICurrencyConverterService/ConvertToWordResponse")]
        System.Threading.Tasks.Task<string> ConvertToWordAsync(decimal usdCurrency);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyConverterServiceChannel : ConsoleSeviceClient.ConsoleServiceReference.ICurrencyConverterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyConverterServiceClient : System.ServiceModel.ClientBase<ConsoleSeviceClient.ConsoleServiceReference.ICurrencyConverterService>, ConsoleSeviceClient.ConsoleServiceReference.ICurrencyConverterService {
        
        public CurrencyConverterServiceClient() {
        }
        
        public CurrencyConverterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyConverterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConverterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConverterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConvertToWord(decimal usdCurrency) {
            return base.Channel.ConvertToWord(usdCurrency);
        }
        
        public System.Threading.Tasks.Task<string> ConvertToWordAsync(decimal usdCurrency) {
            return base.Channel.ConvertToWordAsync(usdCurrency);
        }
    }
}
