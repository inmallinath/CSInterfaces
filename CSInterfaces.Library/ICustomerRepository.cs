using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomer(string lastName);

        void AddCustomer(Customer customer);

        void UpdateCustomer(string lastName, Customer updatedCustomer);

        void DeleteCustomer(string lastName);

        void UpdateCustomers(IEnumerable<Customer> updatedCustomers);

    }
}
