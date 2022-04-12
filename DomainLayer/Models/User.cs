using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class User:BaseEntity
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Email { get; set; }
        public bool Active { get; set; }

    }
}
