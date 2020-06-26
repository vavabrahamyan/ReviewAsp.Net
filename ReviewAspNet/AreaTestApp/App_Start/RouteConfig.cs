using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AreaTestApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            Route newRoute = new Route("{controller}/{action}", new MyRouteHandler());
            routes.Add(newRoute);
        }
    }
    public class MyRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MyHttpHandler();
        }
    }
    public class MyHttpHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<h2> A es shat gidem? </h2>");
        }
    }
}
