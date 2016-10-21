using CSInterfaces.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfacesRepository.Service
{
    public class ServiceRepository : ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(string lastName)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string lastName, Customer updatedCustomer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomers(IEnumerable<Customer> updatedCustomers)
        {
            throw new NotImplementedException();
        }
    }
}
