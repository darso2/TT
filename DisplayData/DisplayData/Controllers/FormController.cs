using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayData.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Process(string N, string R, string M)
        {
            ViewData["name"] = N;
            
                ViewData["Regno"] = int.Parse(R);
            
                ViewData["marks"] = int.Parse(M);
            
            return View();
        }
    }
}