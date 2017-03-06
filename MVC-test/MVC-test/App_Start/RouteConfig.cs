using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "test",
                url: "test1",
                defaults: new { controller = "test", action = "Tester", id = UrlParameter.Optional }
            );


            routes.MapRoute(
    name: "testing",
    url: "GREET",
    defaults: new { controller = "Second", action = "Greetings", id = UrlParameter.Optional }
);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
