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
            return View();
        }
        
        [Route("About/history")]

        public IActionResult AboutHistory()
        {
            return View();
        }
        [Route("About/location")]

        public IActionResult AboutLocation()
        {
            return View();
        }
    }
}