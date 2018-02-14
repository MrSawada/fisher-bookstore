using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fisher.Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers
{
    public class BooksController : Controller
    {
        [Route("Books")]
        
        public IActionResult Books()
        {
            var books = GetBooks();
            return View(books);
        }
        
        [Route("Books/New")]

        public IActionResult BooksNew()
        {
            return View();
        }

        private IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book(){
                Title = "Continuous Delivery",
                Author = new Author(){Name = "Jez Humble"}
            });

            books.Add(new Book(){
                Title = "Lean Enterprise",
                Author = new Author(){Name = "Barry O'Reilly"}
            });

            books.Add(new Book(){
                Title = "The Goal",
                Author = new Author(){Name = "Eliyahu Goldratt"}
            });
            
            return books;
        }
    }
}