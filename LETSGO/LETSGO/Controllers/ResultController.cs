using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LETSGO.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult addtogether(int a, int b)
        {
            ViewData["a"] = a;
            ViewData["b"] = b;
            ViewData["result"] = a + b;
            return View();
        }
    }
}