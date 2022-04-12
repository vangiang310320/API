using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class ProductImageDTO
    {
        public int Id { get; set; }
        public String ImagePath { get; set; }
        public String IsDefault { get; set; }
        public String Active { get; set; }
        public int ProductId { get; set; }
    }
}
