<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCAccesoADatos.Persona>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Delete</title>
</head>
<body>
    <h3>¿Estás seguro de eliminar el registro?</h3>
    <fieldset>
        <legend>Datos</legend>
        
        <div class="display-label">IdPersona</div>
        <div class="display-field"><%: Model.IdPersona %></div>
        
        <div class="display-label">NombrePersona</div>
        <div class="display-field"><%: Model.NombrePersona %></div>
        
        <div class="display-label">Ciudad</div>
        <div class="display-field"><%: Model.Ciudad %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</body>
</html>

