<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<TiendaRegalosMVC.Models.Regalo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Regalos</h2>

    <table>
        <tr>
            <th>       
            </th>
            <th>
                IdRegalo
            </th>
            
            <th>
                NombreRegalo
            </th>
            <th>
                Precio
            </th>
            <th>
                Imagen
            </th>
            <th>
                Categoria
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdRegalo }) %> |
                <%: Html.ActionLink("Eliminar", "Delete", new { id=item.IdRegalo })%>
            </td>
            <td>
                <%: item.IdRegalo %>
            </td>
            <td>
                <%: item.NombreRegalo %>
            </td>
            <td>
                <%: String.Format("{0:c}", item.Precio) %>
            </td>
            <td>
                <%: item.Imagen %>
            </td>
            <td>
                <%: item.Categorias.NombreCategoria %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear un nuevo regalo", "Create") %>
    </p>

</asp:Content>

