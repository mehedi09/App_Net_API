using ELPL_API.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELPL_API.Controllers
{
    public class HomeController : Controller
    {
        BasicUtilities _BasicUtilities = new BasicUtilities();
        public ActionResult Index()
        {
            ViewBag.Title = "API TEST";

            return View();
        }

  
    }
}
