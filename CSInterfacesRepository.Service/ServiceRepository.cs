using CSInterfaces.Library;
using CSInterfacesRepository.Service.MyCustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
