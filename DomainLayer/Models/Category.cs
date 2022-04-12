using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Category:BaseEntity
    {
        public String CategoryName { get; set; }
        public String Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}