using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Product:BaseEntity
    {
        public String ProductName { get; set; }
        public String Sale { get; set; }
        public String Price { get; set; }
        public String Description { get; set; }
        public String Discount { get; set; }
        public String Viewcount { get; set; }
        public String Image { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<ProductImage> ProductImages { get; set; }
        public virtual List<ProductSize> ProductSizes { get; set; }
        public virtual List<ProductColor> ProductColors { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}