using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaRegalosMVC.Models
{
    public partial class Pedido
    {
        private static TiendaRegalosEntities
            db = new TiendaRegalosEntities();

        
        public static List<Pedido> getPedidosNoEnviados()
        {
            return (from oPedido in db.Pedidos
                    where oPedido.FechaEnvio == null
                    select oPedido).ToList();
        }

        public static List<Pedido> getPedidosEnviados()
        {
            return (from oPedido in db.Pedidos
                    where oPedido.FechaEnvio != null
                    select oPedido).ToList();
        }
    }
}