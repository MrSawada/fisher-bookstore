using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        [Route("Books")]
        
        public IActionResult Books()
        {
            return View();
        }
        
        [Route("Books/New")]

        public IActionResult BooksNew()
        {
            return View();
        }
    }
}