using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaRegalosDAO
{
    public partial class Pedido
    {
        static TiendaRegalosEntities tienda =
            new TiendaRegalosEntities();

        // Esta propiedad nos dice si el pedido
        // ha sido enviado o no. Es de sólo lectura 
        // (no tiene set)
        public bool Enviado
        {
            get
            {
                return this.FechaEnvio != null;
            }
        }

        // Esta propiedad nos dice la ciudad de 
        // procedencia del pedido. Es de sólo lectura 
        // (no tiene set)
        public string ProcedenciaPedido
        {
            get
            {
                return this.Clientes.Ciudad;
            }
        }

        // Este método devuelve el Pedido según 
        // el id especificado
        public static Pedido getPedido(int aIdPedido)
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.IdPedido == aIdPedido
                    select oPedido).FirstOrDefault();
        }

        // Este método devuelve los pedidos según la 
        // fecha especificada
        public static List<Pedido> getPedidos
            (DateTime aFechaPedido)
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.FechaPedido == aFechaPedido
                    select oPedido).ToList();
        }

        // Este método devuelve los pedidos según 
        // el mes especificado
        public static List<Pedido> getPedidos(int aMes)
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.FechaPedido.Month == aMes
                    select oPedido).ToList();
        }

        // Este método devuelve los pedidos según 
        // el cliente especificado
        public static List<Pedido> 
            getPedidosCliente(int aIdCliente)
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.ClientesIdCliente == aIdCliente
                    select oPedido).ToList();
        }

        // Este método devuelve los pedidos con fecha de envío
        public static List<Pedido> getPedidosEnviados()
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.FechaEnvio != null
                    select oPedido).ToList();
        }

        // Este método devuelve los pedidos sin fecha de envío
        public static List<Pedido> getPedidosNoEnviados()
        {
            return (from oPedido in tienda.Pedidos
                    where oPedido.FechaEnvio == null
                    select oPedido).ToList();
        }

        // Este método devuelve todos los Pedidos a una lista
        public static List<Pedido> getPedidos()
        {
            return (from oPedido in tienda.Pedidos
                    select oPedido).ToList();
        }

        // Este método devuelve los detalles del pedido
        public List<RegaloPedido> getListaDetallesPedido()
        {
            return (from oDetalles in this.RegalosPedido
                    orderby oDetalles.RegalosIdRegalo
                    select oDetalles).ToList();
        }

        // Este método marca un pedido como enviado 
        // (le pone fecha de envío)
        public void MarcarComoEnviado()
        {
            this.FechaEnvio = DateTime.Now;
            tienda.SaveChanges();
        }
    }
}
