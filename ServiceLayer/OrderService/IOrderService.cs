using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.OrderService
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrder();
        Order GetOrder(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
    }
}
