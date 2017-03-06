using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DisplayData
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
    name: "qad",
    url: "QA",
    defaults: new { controller = "Manchester", action = "showForm", id = UrlParameter.Optional }
);
            routes.MapRoute(
                name: "Resultpage",
                url: "ProcessForm",
                defaults: new { controller = "Form", action = "Process", id = UrlParameter.Optional});

            
        }
    }
}
