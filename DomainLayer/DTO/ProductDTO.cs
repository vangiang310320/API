using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public String ProductName { get; set; }
        public String Sale { get; set; }
        public String Price { get; set; }
        public String Description { get; set; }
        public String Discount { get; set; }
        public String Viewcount { get; set; }
        public String Image { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

    }
}
