using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.OrderDetailService
{
    public class OrderDetailService : IOrderDetailService
    {
        private IRepository<OrderDetail> repo;
        public OrderDetailService(IRepository<OrderDetail> repo)
        {
            this.repo = repo;
        }

        public void DelateOrderDetail(int id)
        {
            OrderDetail orderDetail = repo.Get(id);
            repo.Remove(orderDetail);
            repo.SaveChanges();
        }

        public object GetAllOrderDetail()
        {
            return repo.GetAll();
        }

        public IEnumerable<OrderDetail> GetOrderDetail()
        {
            return repo.GetAll();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return repo.Get(id);
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            repo.Insert(orderDetail);
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            repo.Update(orderDetail);
        }
    }
}
