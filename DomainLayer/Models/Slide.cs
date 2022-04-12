using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Slide:BaseEntity
    {
        public String SlideName { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }
        public String Url { get; set; }
        public String SortOrder { get; set; }
        public String Status { get; set; }
    }
}
