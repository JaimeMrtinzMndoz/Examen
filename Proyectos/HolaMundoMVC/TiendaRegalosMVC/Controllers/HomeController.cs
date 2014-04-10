using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaRegalosMVC.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bienvenido a nuestra web";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
