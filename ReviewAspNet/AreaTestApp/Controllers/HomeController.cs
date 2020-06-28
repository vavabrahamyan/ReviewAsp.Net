using AreaTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTestApp.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        [Route("Account")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit()
        {
            LogModel lm = new LogModel { Login = ".parliament.", Password = "pdfasda" };
            return View(lm);
        }
        public ActionResult Details()
        {
            var book = db.Books.FirstOrDefault();
            return View(book);
        }

        [Route("Test/{name}/{id}")]
        public string Test(int id, string name)
        {
            return $"<h2> id:{id} => name:{name} </h2>";
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
    }
}