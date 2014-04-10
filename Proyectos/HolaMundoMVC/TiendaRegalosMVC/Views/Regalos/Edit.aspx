<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TiendaRegalosMVC.Models.Regalo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <%: Html.HiddenFor(model => model.IdRegalo) %>  
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombreRegalo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreRegalo) %>
                <%: Html.ValidationMessageFor(model => model.NombreRegalo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Precio) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Precio, String.Format("{0:F}", Model.Precio)) %>
                <%: Html.ValidationMessageFor(model => model.Precio) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Imagen) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Imagen) %>
                <%: Html.ValidationMessageFor(model => model.Imagen) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CategoriasIdCategoria) %>
            </div>
            <div class="editor-field">
                <%: Html.DropDownList("CategoriasIdCategoria") %>
                <%: Html.ValidationMessageFor(model => 
                model.CategoriasIdCategoria) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

