using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Models
{
    public class Line
    {
        public int LineID { get; set; }
        public string Title { get; set; }
        public ICollection<CustomerLine> CustomerLines { get; set; }
    }
}
