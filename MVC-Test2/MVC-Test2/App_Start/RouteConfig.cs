using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Test2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "home",
                defaults: new { controller = "Home", action = "showHome", id = UrlParameter.Optional });

            routes.MapRoute(name: "getAddition", url: "add/{a}/{b}", defaults: new { controller = "Math", action = "Addition", id = UrlParameter.Optional });
            routes.MapRoute(name: "getSubtraction", url: "subtract/{a}/{b}", defaults: new { controller = "Math", action = "subtraction", id = UrlParameter.Optional });
            routes.MapRoute(name: "getMultiplication", url: "multiply/{a}/{b}", defaults: new { controller = "Math", action = "multiplication", id = UrlParameter.Optional });
            routes.MapRoute(name: "getDivision", url: "divide/{a}/{b}", defaults: new { controller = "Math", action = "division", id = UrlParameter.Optional });

        }
    }
}
