using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaRegalosDAO;

namespace TiendaRegalos2014
{
    public partial class ConsultasVarias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink lnkActivo = (HyperLink)this.Master.FindControl("linkConsultas");
            lnkActivo.CssClass = "active";
        }

        protected void lnkListaClientes_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes;
            clientes = Cliente.getClientes();
            gvConsultas.DataSource = clientes;
            gvConsultas.DataBind();
        }

        protected void lnkClientesCiudad_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text.Trim() != "")
            {
                List<Cliente> clientes;
                clientes = Cliente.getClienteCiudad
                    (txtCiudad.Text);
                gvConsultas.DataSource = clientes;
                gvConsultas.DataBind();
            }
        }

        protected void lnkClientesCuyoNombre_Click(object sender, EventArgs e)
        {
            if (txtNombreContiene.Text.Trim() != "")
            {
                List<Cliente> clientes;
                clientes = Cliente.getClientes
                    (txtNombreContiene.Text);
                gvConsultas.DataSource = clientes;
                gvConsultas.DataBind();
            }
        }

        protected void lnkPedidosMes_Click(object sender, EventArgs e)
        {
            int mes = 0;
            if (txtMes.Text.Trim() != "" &&
                int.TryParse(txtMes.Text, out mes) == true)
            {
                List<Pedido> pedidos;
                pedidos = Pedido.getPedidos(mes);
                gvConsultas.DataSource = pedidos;
                gvConsultas.DataBind();
            }
        }

        protected void lnkPedidosCliente_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (txtIdCliente.Text.Trim()
                != "" && int.TryParse(txtIdCliente.Text,
                out id) == true)
            {
                List<Pedido> pedidos;
                pedidos = Pedido.getPedidosCliente(id);
                gvConsultas.DataSource = pedidos;
                gvConsultas.DataBind();
            }
        }

        protected void lnkPedidosEnviados_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos;
            pedidos = Pedido.getPedidosEnviados();
            gvConsultas.DataSource = pedidos;
            gvConsultas.DataBind();
        }

        protected void lnkDetallesPedido_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (txtIdPedido.Text.Trim() != "" && int.TryParse
                (txtIdPedido.Text.Trim(), out id) == true)
            {
                Pedido p = new Pedido();
                p = Pedido.getPedido(id);
                List<RegaloPedido> detalles =
                    p.getListaDetallesPedido();
                gvConsultas.DataSource = detalles;
                gvConsultas.DataBind();
            }
        }
    }
}