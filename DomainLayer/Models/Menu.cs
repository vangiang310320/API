using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Menu:BaseEntity
    {
        public String MenuName { get; set; }
        public String Url { get; set; }
        public String SortOrder { get; set; }
        public String ParentId { get; set; }
    }
}
