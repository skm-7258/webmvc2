using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webmvc2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Enail { get; set; }
        public string Mobile{ get; set; }
        public Location Location{ get; set; }
    }
}
