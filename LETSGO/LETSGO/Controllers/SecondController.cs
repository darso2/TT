using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LETSGO.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult storenumber(int a)
        {
            ViewData["first"] = a;
            return View();
        }
    }
}