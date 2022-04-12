using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.OrderService
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> repo;
        public OrderService(IRepository<Order> repo)
        {
            this.repo = repo;
        }
        public void DeleteOrder(int id)
        {
            Order order = repo.Get(id);
            repo.Remove(order);
            repo.SaveChanges();
        }

        public IEnumerable<Order> GetAllOrder()
        {
            return repo.GetAll();
        }

        public Order GetOrder(int id)
        {
            return repo.Get(id);
        }

        public void InsertOrder(Order order)
        {
            repo.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            repo.Update(order);
        }
    }
}
