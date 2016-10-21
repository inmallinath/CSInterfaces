using System;
using System.Collections.Generic;
using CSInterfaces.Library;

namespace CSIntefaces.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Service Client for Serviceing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer() { FirstName = "One", LastName = "Service1", EmailAddress = "One@Service1.com", Rating = 5, StartDate = new DateTime(1977, 11, 23) },
                new Customer() { FirstName = "Two", LastName = "Service2", EmailAddress = "Two@Service2.com", Rating = 7, StartDate = new DateTime(1978, 11, 23) },
                new Customer() { FirstName = "Three", LastName = "Service3", EmailAddress = "Three@Service3.com", Rating = 8, StartDate = new DateTime(1979, 11, 23) },
                new Customer() { FirstName = "Four", LastName = "Service4", EmailAddress = "Four@Service4.com", Rating = 9, StartDate = new DateTime(1976, 11, 23) }
            };
            return customers;
        }

        public void AddCustomer(Customer newCustomer)
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

        

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void UpdateCustomer(List<Customer> updatedCustomer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string lastName, Customer updatedCustomer)
        {
            throw new NotImplementedException();
        }
    }
}
