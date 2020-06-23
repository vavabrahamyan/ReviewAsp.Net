using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutesApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional},
                constraints: new {myConstraint = new CustomConstraint("/Home/Index/16")}
            );

            Route newRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            routes.Add(newRoute);
        }
    }
    public class CustomConstraint : IRouteConstraint
    {
        private string uri;
        public CustomConstraint(string uri)
        {
            this.uri = uri;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,
                               RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !(uri == httpContext.Request.Url.AbsolutePath);
        }
    }
}
