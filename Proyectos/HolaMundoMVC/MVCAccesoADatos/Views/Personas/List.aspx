<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCAccesoADatos.Persona>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>List</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdPersona
            </th>
            <th>
                NombrePersona
            </th>
            <th>
                Ciudad
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.IdPersona }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.IdPersona })%>
            </td>
            <td>
                <%: item.IdPersona %>
            </td>
            <td>
                <%: item.NombrePersona %>
            </td>
            <td>
                <%: item.Ciudad %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</body>
</html>

