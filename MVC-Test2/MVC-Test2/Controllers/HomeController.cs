using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult showHome()
        {
            return View("homePage");
        }
    }
}