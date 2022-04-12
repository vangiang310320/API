using DomainLayer.Models;
using RepositoryLayer.Repository;
using ServiceLayer.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> repo;
        public CustomerService(IRepository<Customer> repo)
        {
            this.repo = repo;
        }
        public void DeleteCustomer(int id)
        {
            Customer customer = repo.Get(id);
            repo.Remove(customer);
            repo.SaveChanges();
        }
        public Customer GetCustomer(int id)
        {
            return repo.Get(id);
        }
        public void UpdateCustomer(Customer customer)
        {
            repo.Update(customer);
        }
        public IEnumerable<Customer> GetAllCustomer()
        {
            return repo.GetAll();
        }
        public void InserCustomer(Customer customer)
        {
            repo.Insert(customer);
        }
    }
}