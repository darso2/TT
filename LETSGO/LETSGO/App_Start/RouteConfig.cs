using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LETSGO
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                name: "homePage",
                url: "home",
                defaults: new { controller = "Home", action = "showPage", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "SecondPage",
                url: "second/{a}",
                defaults: new { controller = "Second", action = "storenumber", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ResultsPage",
                url: "result/{a}/{b}",
                defaults: new { controller = "Result", action = "addtogether", id = UrlParameter.Optional }
            );
        }
    }
}
