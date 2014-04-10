using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaRegalosMVC.Models;

namespace TiendaRegalosMVC.Controllers
{
    [Authorize]
    public class ConsultasController : Controller
    {
        private TiendaRegalosEntities db = new TiendaRegalosEntities();

        //
        // GET: /Consultas/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PedidosEnviados()
        {
            return View(Pedido.getPedidosEnviados());
        }
    }

}
