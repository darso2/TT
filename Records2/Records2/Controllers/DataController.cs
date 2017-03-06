using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Records2.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult home()
        {
            return View("form1");
        }

        public ActionResult showInfo(string Name, int Regno, int Marks)
        {
            Models.Class1 info = new Models.Class1();
            info.Name = Name;
            info.Regno = Regno;
            info.Marks = Marks; 
            return View("results", "Class1");
        }
    }
}