using AsyncTaskApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AsyncTaskApp.Controllers
{
    public class HomeController : Controller
    {
        private BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books.ToList();
            ViewBag.Books = books;
            return View();
        }
        //async action
        public async Task<ActionResult> BookList()
        {
            IEnumerable<Book> books = await db.Books.ToListAsync();
            ViewBag.Books = books;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(new Book { Name = "Bla-Bla", Author = "He", Price = 1800, Id = 1 } );
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}