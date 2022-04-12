using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Order:BaseEntity
    {
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public String TotalMoney { get; set; }
        public String Payment { get; set; }
        public DateTime BookingDate { get; set; }
        public String DeliveryData { get; set; }
        public String ShippingWay { get; set; }
        public String Sate { get; set; }
        public String Note { get; set; }
        public Double TransportFee { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
