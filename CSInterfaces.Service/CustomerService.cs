﻿using CSInterfaces.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CSInterfaces.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer() { FirstName = "One", LastName = "Test1", EmailAddress = "One@Test1.com", Rating = 5, StartDate = new DateTime(1977, 11, 23) },
                new Customer() { FirstName = "Two", LastName = "Test2", EmailAddress = "Two@Test2.com", Rating = 7, StartDate = new DateTime(1978, 11, 23) },
                new Customer() { FirstName = "Three", LastName = "Test3", EmailAddress = "Three@Test3.com", Rating = 8, StartDate = new DateTime(1979, 11, 23) },
                new Customer() { FirstName = "Four", LastName = "Test4", EmailAddress = "Four@Test4.com", Rating = 9, StartDate = new DateTime(1976, 11, 23) }
            };
            return customers;
        }
    }
}
