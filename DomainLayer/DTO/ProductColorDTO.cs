using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class ProductColorDTO
    {
        public int Id { get; set; }
        public String Color { get; set; }
        public String Active { get; set; }
        public int ProductId { get; set; }
    }
}
