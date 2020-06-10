using ReviewAspNet.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ReviewAspNet.Controllers
{
    public class MyController :  Controller , IController
    {
        //public void Execute(RequestContext requestContext)
        //{
        //    var ip = requestContext.HttpContext.Request.UserHostAddress;
        //    var response = requestContext.HttpContext.Response;
        //    response.Write($"<h2> your ip is - {ip}<h2>");
        //}
        public ActionResult GetIp()
        {
            return View();
        }
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

        public ActionResult GetHtml()
        {
            return new HtmlResult("<p>Hello world</p>");
        }

        public ActionResult GetImage()
        {
            string path = @"C:\Users\user\Desktop\Working_Folder\ReviewAsp.Net\ReviewAspNet\ReviewAspNet\Content\images\Captures 5_4_2020 2_31_01 PM.png";
            return new ImageResult(path);
        }

        
    }
}