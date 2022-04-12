using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public String CompanyName { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
    }
}
