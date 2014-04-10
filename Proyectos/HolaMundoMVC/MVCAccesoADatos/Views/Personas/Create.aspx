<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCAccesoADatos.Persona>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdPersona) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdPersona) %>
                <%: Html.ValidationMessageFor(model => model.IdPersona) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombrePersona) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombrePersona) %>
                <%: Html.ValidationMessageFor(model => model.NombrePersona) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Ciudad) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Ciudad) %>
                <%: Html.ValidationMessageFor(model => model.Ciudad) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</body>
</html>

