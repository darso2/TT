using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_test.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Greetings()
        {
            ViewData["friend"] = "Worlds";
            ViewData["greet"] = "Hello";
            return View("earth");
        }
    }
}