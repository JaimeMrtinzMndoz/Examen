<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<TiendaRegalosMVC.Models.Categoria>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Categorias</h2>

    <table>
        <tr>
            <th></th>
            <th>
                IdCategoria
            </th>
            <th>
                NombreCategoria
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdCategoria }) %> |
                <%: Html.ActionLink("Borrar", "Delete", new { id=item.IdCategoria })%>
            </td>
            <td>
                <%: item.IdCategoria %>
            </td>
            <td>
                <%: item.NombreCategoria %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Nueva categoría", "Create") %>
    </p>

</asp:Content>

