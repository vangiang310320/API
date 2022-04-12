using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductSize:BaseEntity
    {
        public String Size { get; set; }
        public String Active { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
