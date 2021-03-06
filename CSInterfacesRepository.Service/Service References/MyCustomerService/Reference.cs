﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSInterfacesRepository.Service.MyCustomerService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyCustomerService.ICustomerService")]
    public interface ICustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        System.Collections.Generic.List<CSInterfaces.Library.Customer> GetCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomers", ReplyAction="http://tempuri.org/ICustomerService/GetCustomersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<CSInterfaces.Library.Customer>> GetCustomersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        CSInterfaces.Library.Customer GetCustomer(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/GetCustomer", ReplyAction="http://tempuri.org/ICustomerService/GetCustomerResponse")]
        System.Threading.Tasks.Task<CSInterfaces.Library.Customer> GetCustomerAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        void AddCustomer(CSInterfaces.Library.Customer newCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/AddCustomer", ReplyAction="http://tempuri.org/ICustomerService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(CSInterfaces.Library.Customer newCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        void UpdateCustomer(string lastName, CSInterfaces.Library.Customer updatedCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomer", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomerResponse")]
        System.Threading.Tasks.Task UpdateCustomerAsync(string lastName, CSInterfaces.Library.Customer updatedCustomer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        void DeleteCustomer(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomerService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomers", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomersResponse")]
        void UpdateCustomers(System.Collections.Generic.List<CSInterfaces.Library.Customer> updatedCustomers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomerService/UpdateCustomers", ReplyAction="http://tempuri.org/ICustomerService/UpdateCustomersResponse")]
        System.Threading.Tasks.Task UpdateCustomersAsync(System.Collections.Generic.List<CSInterfaces.Library.Customer> updatedCustomers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomerServiceChannel : CSInterfacesRepository.Service.MyCustomerService.ICustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomerServiceClient : System.ServiceModel.ClientBase<CSInterfacesRepository.Service.MyCustomerService.ICustomerService>, CSInterfacesRepository.Service.MyCustomerService.ICustomerService {
        
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
        
        public System.Collections.Generic.List<CSInterfaces.Library.Customer> GetCustomers() {
            return base.Channel.GetCustomers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<CSInterfaces.Library.Customer>> GetCustomersAsync() {
            return base.Channel.GetCustomersAsync();
        }
        
        public CSInterfaces.Library.Customer GetCustomer(string lastName) {
            return base.Channel.GetCustomer(lastName);
        }
        
        public System.Threading.Tasks.Task<CSInterfaces.Library.Customer> GetCustomerAsync(string lastName) {
            return base.Channel.GetCustomerAsync(lastName);
        }
        
        public void AddCustomer(CSInterfaces.Library.Customer newCustomer) {
            base.Channel.AddCustomer(newCustomer);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(CSInterfaces.Library.Customer newCustomer) {
            return base.Channel.AddCustomerAsync(newCustomer);
        }
        
        public void UpdateCustomer(string lastName, CSInterfaces.Library.Customer updatedCustomer) {
            base.Channel.UpdateCustomer(lastName, updatedCustomer);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerAsync(string lastName, CSInterfaces.Library.Customer updatedCustomer) {
            return base.Channel.UpdateCustomerAsync(lastName, updatedCustomer);
        }
        
        public void DeleteCustomer(string lastName) {
            base.Channel.DeleteCustomer(lastName);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(string lastName) {
            return base.Channel.DeleteCustomerAsync(lastName);
        }
        
        public void UpdateCustomers(System.Collections.Generic.List<CSInterfaces.Library.Customer> updatedCustomers) {
            base.Channel.UpdateCustomers(updatedCustomers);
        }
        
        public System.Threading.Tasks.Task UpdateCustomersAsync(System.Collections.Generic.List<CSInterfaces.Library.Customer> updatedCustomers) {
            return base.Channel.UpdateCustomersAsync(updatedCustomers);
        }
    }
}
