using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AboutController : Controller
    {
        [Route("About")]
        [Route("About/index")]
        
        public IActionResult About()
        {
            return Content("About hello world");
        }
        
        [Route("About/history")]

        public IActionResult AboutHistory()
        {
            return Content("HISTORY hello world");
        }
        [Route("About/location")]

        public IActionResult AboutLocation()
        {
            return Content("Location hello world");
        }
    }
}