<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<TiendaRegalosMVC.Models.Pedido>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	PedidosEnviados
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Pedidos</h2>

    <table>
        <tr>
            <th>
                IdPedido
            </th>
            <th>
                FechaPedido
            </th>
            <th>
                Importe
            </th>
            <th>
                ClientesIdCliente
            </th>
            <th>
                FechaEnvio
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.IdPedido %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaPedido) %>
            </td>
            <td>
                <%: String.Format("{0:c}", item.Importe) %>
            </td>
            <td>
                <%: item.Clientes.NombreCliente %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaEnvio) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Volver atrás", "Index") %>
    </p>

</asp:Content>

