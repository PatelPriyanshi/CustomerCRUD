﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Customer_Client.CustomerService_Test {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomerService_Test.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerRecordResponse")]
        string AddCustomerRecord(Customer_WCFService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerRecordResponse")]
        System.Threading.Tasks.Task<string> AddCustomerRecordAsync(Customer_WCFService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerRecords", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerRecordsResponse")]
        System.Data.DataSet GetCustomerRecords(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomerRecords", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCustomerRecordsAsync(int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerRecordResponse")]
        string DeleteCustomerRecord(Customer_WCFService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerRecordResponse")]
        System.Threading.Tasks.Task<string> DeleteCustomerRecordAsync(Customer_WCFService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerRecordResponse")]
        string UpdateCustomerRecord(Customer_WCFService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomerRecord", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerRecordResponse")]
        System.Threading.Tasks.Task<string> UpdateCustomerRecordAsync(Customer_WCFService.Customer customer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : Customer_Client.CustomerService_Test.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<Customer_Client.CustomerService_Test.ICustomerService>, Customer_Client.CustomerService_Test.ICustomerService {
        
        public CustomerServiceClient() {
        }
        
        public CustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddCustomerRecord(Customer_WCFService.Customer customer) {
            return base.Channel.AddCustomerRecord(customer);
        }
        
        public System.Threading.Tasks.Task<string> AddCustomerRecordAsync(Customer_WCFService.Customer customer) {
            return base.Channel.AddCustomerRecordAsync(customer);
        }
        
        public System.Data.DataSet GetCustomerRecords(int customerId) {
            return base.Channel.GetCustomerRecords(customerId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCustomerRecordsAsync(int customerId) {
            return base.Channel.GetCustomerRecordsAsync(customerId);
        }
        
        public string DeleteCustomerRecord(Customer_WCFService.Customer customer) {
            return base.Channel.DeleteCustomerRecord(customer);
        }
        
        public System.Threading.Tasks.Task<string> DeleteCustomerRecordAsync(Customer_WCFService.Customer customer) {
            return base.Channel.DeleteCustomerRecordAsync(customer);
        }
        
        public string UpdateCustomerRecord(Customer_WCFService.Customer customer) {
            return base.Channel.UpdateCustomerRecord(customer);
        }
        
        public System.Threading.Tasks.Task<string> UpdateCustomerRecordAsync(Customer_WCFService.Customer customer) {
            return base.Channel.UpdateCustomerRecordAsync(customer);
        }
    }
}