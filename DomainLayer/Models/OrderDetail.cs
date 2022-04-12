using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class OrderDetail:BaseEntity
    {
        public int Quantity { get; set; }
        public Product product  { get; set; }
        public  Order order { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}