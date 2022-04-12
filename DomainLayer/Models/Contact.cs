using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public String ContactName { get; set; }
        public String Fax { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
    }
}
