using ArrayMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArrayMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Array()
        {
            return View();
        }
        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            for (int i = 0; i < names.Count; i++)
            {
                fin += $"{names[i]}; ";
            }
            return fin;
        }
        [HttpGet]
        public ActionResult Edit()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Author = "A", Name = "A_book", Price = 190 });
            books.Add(new Book { Author = "B", Name = "B_book", Price = 260 });
            books.Add(new Book { Author = "C", Name = "C_book", Price = 110 });
            return View(books);
        }
        [HttpPost]
        public string Edit(List<Book> books)
        {
            return books.Count.ToString();
        }
    }
}