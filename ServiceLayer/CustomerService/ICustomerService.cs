using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomerService
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomer(int id);
        void InserCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
    }
}
