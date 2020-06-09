using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReviewAspNet.Util
{
    public class HtmlResult : ActionResult
    {
        private string htmlCode;
        public HtmlResult(string html)
        {
            htmlCode = html;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            string FullHtml = "<!DOCTYPE html><html><head>";
            FullHtml += "<title>Home page</title>";
            FullHtml += "<meta charset=utf-8 />";
            FullHtml += "</head><body>";
            FullHtml += htmlCode;
            FullHtml += "</body></html>";
            context.HttpContext.Response.Write(FullHtml);
        }
    }
}