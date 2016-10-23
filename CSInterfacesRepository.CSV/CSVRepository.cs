using CSInterfaces.Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInterfacesRepository.CSV
{
    public class CSVRepository : ICustomerRepository
    {
        string path;

        public CSVRepository()
        {
            var fileName = ConfigurationManager.AppSettings["CSVFileName"];
            path = AppDomain.CurrentDomain.BaseDirectory + fileName;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            if (File.Exists(path))
            {
                var streamReader = new StreamReader(path);
                string line;
                while ((line = streamReader.ReadLine()) !=  null)
                {
                    var elems = line.Split(',');
                    var customer = new Customer()
                    {
                        FirstName = elems[0],
                        LastName = elems[1],
                        StartDate = DateTime.Parse(elems[2]),
                        Rating = Int32.Parse(elems[3])
                    };
                    customers.Add(customer);
                }
            }
            return customers;
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
