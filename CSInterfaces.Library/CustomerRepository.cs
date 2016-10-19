using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfaces.Library
{
    public class CustomerRepository
    {
        public Customer[] GetCustomers()
        {
            var customers = new Customer[]
            {
                new Customer() { FirstName = "One", LastName = "Test1", EmailAddress = "One@Test1.com", Rating = 5, StartDate = new DateTime(1977, 11, 23) },
                new Customer() { FirstName = "Two", LastName = "Test2", EmailAddress = "Two@Test2.com", Rating = 7, StartDate = new DateTime(1978, 11, 23) },
                new Customer() { FirstName = "Three", LastName = "Test3", EmailAddress = "Three@Test3.com", Rating = 8, StartDate = new DateTime(1979, 11, 23) },
                new Customer() { FirstName = "Four", LastName = "Test4", EmailAddress = "Four@Test4.com", Rating = 9, StartDate = new DateTime(1976, 11, 23) },
                new Customer() { FirstName = "Five", LastName = "Test5", EmailAddress = "Five@Test5.com", Rating = 10, StartDate = new DateTime(1974, 11, 23) },
                new Customer() { FirstName = "Six", LastName = "Test6", EmailAddress = "Six@Test6.com", Rating = 3, StartDate = new DateTime(1975, 11, 23) },
                new Customer() { FirstName = "Seven", LastName = "Test7", EmailAddress = "Seven@Test7.com", Rating = 4, StartDate = new DateTime(1972, 11, 23) },
                new Customer() { FirstName = "Eight", LastName = "Test8", EmailAddress = "Eight@Test8.com", Rating = 2, StartDate = new DateTime(1971, 11, 23) },
                new Customer() { FirstName = "Nine", LastName = "Test9", EmailAddress = "Nine@Test9.com", Rating = 1, StartDate = new DateTime(1974, 11, 23) },
                new Customer() { FirstName = "Ten", LastName = "Test10", EmailAddress = "Ten@Test10.com", Rating = 6, StartDate = new DateTime(1973, 11, 23) }
            };
            return customers;
        }
    }
}
