using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayData.Controllers
{
    public class ManchesterController : Controller
    {
        // GET: Manchester
        public ActionResult showForm()
        {
            return View("showForm");
        }
    }
}