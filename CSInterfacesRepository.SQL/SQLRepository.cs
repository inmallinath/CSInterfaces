using CSInterfaces.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfacesRepository.SQL
{
    public class SQLRepository : ICustomerRepository
    {

        public IEnumerable<Customer> GetCustomers()
        {
           //EF code goes here to retrieve customers from SQL
        }

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
