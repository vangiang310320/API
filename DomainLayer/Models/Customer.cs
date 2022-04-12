using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer:BaseEntity
    {
        public String CustomerName { get; set; }
        public String Gender { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Avatar { get; set; }
        public String UserName { get; set; }
        public String PassWord { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
