using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E2836.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "How to bind GridView to XPO in Server Mode";

            return View();
        }

        public ActionResult GridViewPartial()
        {
            return PartialView("_GridViewPartial");
        }
    }
}