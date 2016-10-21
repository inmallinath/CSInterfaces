using CSInterfaces.Library;
using System.Collections.Generic;
using System.ServiceModel;

namespace CSIntefaces.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetCustomers();

        [OperationContract]
        Customer GetCustomer(string lastName);

        [OperationContract]
        void AddCustomer(Customer newCustomer);

        [OperationContract]
        void UpdateCustomer(string lastName, Customer updatedCustomer);

        [OperationContract]
        void DeleteCustomer(string lastName);

        [OperationContract]
        void UpdateCustomer(List<Customer> updatedCustomer);
    }
}
