using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class ProductSizeDTO
    {
        public int Id { get; set; }
        public String Size { get; set; }
        public String Active { get; set; }
        public int ProductId { get; set; }
    }
}
