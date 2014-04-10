using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundoMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Nombre"] = "Juan";
            ViewData["Ciudad"] = "Pamplona";
            return View();
        }

        public ActionResult Index2()
        {
            Models.Usuario datos = new Models.Usuario();
            datos.Nombre = "Juan Luis";
            datos.Ciudad = "Pamplona";
            datos.FechaAlta = DateTime.Today;
            return View(datos);
        }

        [HttpPost]
        //Con esto determinamos que este método se dispare cuando
        //se pulse el botón de confirmación de la edad
        public ActionResult Index2(int edad)
        {
            ViewData["edad"] = edad;
            return View("VistaEdad");
            //LLamamos a esta otra vista que es 
            //la que nos sacará la edad
        }
    }
}
