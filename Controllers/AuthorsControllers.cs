using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class AuthorsController : Controller
    {
        [Route("Authors")]
        
        public IActionResult Authors()
        {
            return View();
        }
        
        [Route("Authors/Featured")]

        public IActionResult AuthorsFeatured()
        {
            return View();
        }
    }
}