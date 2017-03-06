using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Records2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "home",
                url: "",
                defaults: new { controller = "Data", action = "home", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "information",
                url:"ProcessMethod",
                defaults: new { controller = "Data", action = "showInfo", id = UrlParameter.Optional}
                );
            }
        }
    }

