using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewAspNet.Controllers
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


        // Improvizations
        public string GetAge(int age)
        {
            return $"<h1> Age is {age}<h1>";
        }
        public string GetNameAndAge(string name, int age)
        {
            return $"<b>{name} is {age} years old<b>";
        }
        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int h = Int32.Parse(Request.Params["h"]);

            int s = a * h / 2;

            return $"Squares area is {s}";
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public string GetBook(string title, string author)
        {
            return $"{title} is create {author}";
        }
        public string PostBook()
        {
            string title = Request.Form["title"];
            string author = Request.Form["author"];

            return $"<h2>{title} is create {author}</h2>";
        }
    }
}