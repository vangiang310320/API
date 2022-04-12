using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductImage:BaseEntity
    {
        public String ImagePath { get; set; }
        public String IsDefault { get; set; }
        public String Active { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}