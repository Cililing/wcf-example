﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFServiceClient.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Add", ReplyAction="http://tempuri.org/ICalculatorService/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Substract", ReplyAction="http://tempuri.org/ICalculatorService/SubstractResponse")]
        double Substract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/Substract", ReplyAction="http://tempuri.org/ICalculatorService/SubstractResponse")]
        System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/AddToMemory", ReplyAction="http://tempuri.org/ICalculatorService/AddToMemoryResponse")]
        double AddToMemory(double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/AddToMemory", ReplyAction="http://tempuri.org/ICalculatorService/AddToMemoryResponse")]
        System.Threading.Tasks.Task<double> AddToMemoryAsync(double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/DeltaTime", ReplyAction="http://tempuri.org/ICalculatorService/DeltaTimeResponse")]
        long DeltaTime(long time);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/DeltaTime", ReplyAction="http://tempuri.org/ICalculatorService/DeltaTimeResponse")]
        System.Threading.Tasks.Task<long> DeltaTimeAsync(long time);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : WCFServiceClient.CalculatorService.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<WCFServiceClient.CalculatorService.ICalculatorService>, WCFServiceClient.CalculatorService.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Substract(double n1, double n2) {
            return base.Channel.Substract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2) {
            return base.Channel.SubstractAsync(n1, n2);
        }
        
        public double AddToMemory(double n2) {
            return base.Channel.AddToMemory(n2);
        }
        
        public System.Threading.Tasks.Task<double> AddToMemoryAsync(double n2) {
            return base.Channel.AddToMemoryAsync(n2);
        }
        
        public long DeltaTime(long time) {
            return base.Channel.DeltaTime(time);
        }
        
        public System.Threading.Tasks.Task<long> DeltaTimeAsync(long time) {
            return base.Channel.DeltaTimeAsync(time);
        }
    }
}
