using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            HttpContext.Response.Cookies["id"].Value = "cg78-t1";
            ViewData["Head"] = long.MaxValue;

            ViewBag.Fruits = new List<string>
            {
                "Apple", "Peach", "Lemon", "Pineapple"
            };

            return View("UlLi");
        }
        public ViewResult MyAction()
        {
            ViewData["Head"] = "hello world(MyAction)";
            return View();
        }
        public ActionResult UlLi()
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
    }
}