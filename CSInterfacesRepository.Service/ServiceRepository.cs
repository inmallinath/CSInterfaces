using CSInterfaces.Library;
using CSInterfacesRepository.Service.MyCustomerService;
using System.Collections.Generic;
using System.Linq;

namespace CSInterfacesRepository.Service
{
    public class ServiceRepository : ICustomerRepository
    {
        CustomerServiceClient serviceProxy = new CustomerServiceClient();

        public IEnumerable<Customer> GetCustomers()
        {
            return serviceProxy.GetCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            serviceProxy.AddCustomer(customer);
        }

        public void DeleteCustomer(string lastName)
        {
            serviceProxy.DeleteCustomer(lastName);
        }

        public Customer GetCustomer(string lastName)
        {
            return serviceProxy.GetCustomer(lastName);
        }

        public void UpdateCustomer(string lastName, Customer updatedCustomer)
        {
            serviceProxy.UpdateCustomer(lastName, updatedCustomer);
        }

        public void UpdateCustomers(IEnumerable<Customer> updatedCustomers)
        {
            serviceProxy.UpdateCustomers(updatedCustomers.ToList());
        }
    }
}
