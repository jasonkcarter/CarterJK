using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CarterJK.App_Start;

namespace CarterJK
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add("HomeRoute",
                       new Route("{viewName}",
                                 new RouteValueDictionary(
                                     new {controller = "Home", action = "Index", viewName = UrlParameter.Optional}),
                                 new SeoRouteHandler())
                );
        }
    }
}