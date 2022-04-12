using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.OrderDetailService
{
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetail> GetOrderDetail();
        OrderDetail GetOrderDetail(int id);
        void InsertOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DelateOrderDetail(int  id);
        object GetAllOrderDetail();
    }
}
