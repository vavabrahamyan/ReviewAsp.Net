using MigrationDBApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MigrationDBApp.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db = new UserContext();
        public ActionResult Index()
        {
            db.Users.AddRange(new List<User>
            {
                new User{Name = "Vahe", Company = new Company{ Name = "Vecto.Digital"} },
                new User{Name = "Razmik", Company = new Company{ Name = "SoftConstruct"} }
            });
            db.SaveChanges();
            return View(db.Users.ToList());
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