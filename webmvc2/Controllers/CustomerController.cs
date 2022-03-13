using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webmvc2.Models;

namespace webmvc2.Controllers
{
    public class CustomerController : Controller
    {
        private webmvc2.Models;
            public CustomerController(webmvc2DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location> locations = webmvc2DbContext.Locations.ToList();
            return View(Location);
        }
    }
}
