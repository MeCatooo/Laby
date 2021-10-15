using ASP_laby.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_laby.Controllers
{
    public class BookController : Controller
    {
        static List<Book> books = new List<Book>();
        public IActionResult Index()
        {
            return View(books);
        }
        public IActionResult AddForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book Book)
        {
            books.Add(Book);
            return View("ConfirmBook", Book);
        }
        public IActionResult List()
        {
            return View(books);
        }
    }
}
