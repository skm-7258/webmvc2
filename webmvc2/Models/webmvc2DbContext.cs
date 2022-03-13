using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webmvc2.Models
{
    public class webmvc2DbContext:DbContext
    {
        public webmvc2DbContext
            (DbContextOptions<webmvc2DbContext>options) :
            base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
