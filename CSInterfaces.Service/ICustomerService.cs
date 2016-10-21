using CSInterfaces.Library;
using System.Collections.Generic;
using System.ServiceModel;

namespace CSInterfaces.Service
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetCustomers();
    }
}