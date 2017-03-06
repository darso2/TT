using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Try2Controller
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "qa",
                url: "QAdsfj",
                defaults: new { controller = "Manchester", action = "showForm", id = UrlParameter.Optional }
            );
            routes.MapRoute(name: "getAddition", url: "QA", defaults: new { controller = "Manchester", action = "showForm", id = UrlParameter.Optional });
        }

    }
}

