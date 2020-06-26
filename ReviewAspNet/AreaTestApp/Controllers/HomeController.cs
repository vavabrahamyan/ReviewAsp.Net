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
        [Route("Account")]
        public ActionResult Index()
        {
            return View();
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