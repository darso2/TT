using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test2.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Addition(int A, int B)
        {
            
            ViewData["operation"] = "Addition";
            ViewData["result"] = A+B;
            return View("result");
        }

        public ActionResult Subtraction(int A, int B)
        {
            ViewData["operation"] = "Subtraction";
            ViewData["result"] = A-B;
            return View("result");
        }
        public ActionResult Multiplication(int A, int B)
        {
            ViewData["operation"] = "Multiplication";
            ViewData["result"] = A*B;
            return View("result");
        }
        public ActionResult Division(float A, float B)
        {
            if (B != 0)
            { ViewData["operation"] = "Division";
            ViewData["result"] = A / B;
            return View("result"); }
            else
            return View("error");
        }
    }
}