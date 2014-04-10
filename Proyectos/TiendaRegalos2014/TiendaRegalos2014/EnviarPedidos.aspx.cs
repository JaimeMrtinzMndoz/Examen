using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaRegalosDAO;

namespace TiendaRegalos2014
{
    public partial class EnviarPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink lnkActivo = (HyperLink)this.Master.FindControl("linkPedidos");
                lnkActivo.CssClass = "active";
        }

        protected void gvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "marcarEnviado")
            {
                int nFila = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = gvPedidos.Rows[nFila];
                // La columna 3 es la del IDPedido
                int nPedido = int.Parse(fila.Cells[3].Text);
                Pedido pedidoMarcar = Pedido.getPedido(nPedido);
                pedidoMarcar.MarcarComoEnviado();
                Response.Write("<script>alert('Pedido marcado como enviado');</script>");
            }
        }

        protected void gvPedidos_PreRender(object sender, EventArgs e)
        {
            //En el Load no lo hace bien
            List<Pedido> pedidos;
            pedidos = Pedido.getPedidosNoEnviados();
            gvPedidos.DataSource = pedidos;
            gvPedidos.DataBind();
        }
    }
}