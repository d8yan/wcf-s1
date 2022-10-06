﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Add", ReplyAction="http://tempuri.org/IService1/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        double Sub(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        System.Threading.Tasks.Task<double> SubAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Mul", ReplyAction="http://tempuri.org/IService1/MulResponse")]
        double Mul(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Mul", ReplyAction="http://tempuri.org/IService1/MulResponse")]
        System.Threading.Tasks.Task<double> MulAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Div", ReplyAction="http://tempuri.org/IService1/DivResponse")]
        double Div(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Div", ReplyAction="http://tempuri.org/IService1/DivResponse")]
        System.Threading.Tasks.Task<double> DivAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string email, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApp1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.IService1>, ConsoleApp1.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Sub(double n1, double n2) {
            return base.Channel.Sub(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubAsync(double n1, double n2) {
            return base.Channel.SubAsync(n1, n2);
        }
        
        public double Mul(double n1, double n2) {
            return base.Channel.Mul(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MulAsync(double n1, double n2) {
            return base.Channel.MulAsync(n1, n2);
        }
        
        public double Div(double n1, double n2) {
            return base.Channel.Div(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivAsync(double n1, double n2) {
            return base.Channel.DivAsync(n1, n2);
        }
        
        public string Login(string email, string password) {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string email, string password) {
            return base.Channel.LoginAsync(email, password);
        }
    }
}
