using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaRegalosMVC.Models;
using System.Data;

namespace TiendaRegalosMVC.Controllers
{
    [Authorize]
    public class PedidosController : Controller
    {
        private TiendaRegalosEntities
            db = new TiendaRegalosEntities();

        //
        // GET: /Pedidos/

        public ActionResult Index()
        {
            // Se puede directamente retornar la vista con 
            // la consulta o llamar al método creado en la 
            // carpeta Models bajo la clase Pedidos
            //return View((from oPedido in db.Pedidos 
            //        where oPedido.FechaEnvio == null
            //        select oPedido).ToList());

            return View(Pedido.getPedidosNoEnviados());
        }

        //
        // GET: /Pedidos/Enviar/5

        public ActionResult Enviar(int id)
        {
            // Capturamos el pedido a enviar y 
            // le modificamos la fecha de envío a la de hoy
            Pedido pedido = db.Pedidos.Single
                (c => c.IdPedido == id);
            pedido.FechaEnvio = DateTime.Now;
            return View(pedido);
        }

        //
        // POST: /Pedidos/Enviar/5

        [HttpPost]
        public ActionResult Enviar(Pedido pedido)
        {
            // Modificamos el pedido y volvemos a 
            //la lista de no enviados
            db.Pedidos.Attach(pedido);
            db.ObjectStateManager.ChangeObjectState
                (pedido, EntityState.Modified);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
