<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TiendaRegalosMVC.Models.Regalo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">IdRegalo</div>
        <div class="display-field"><%: Model.IdRegalo %></div>
        
        <div class="display-label">NombreRegalo</div>
        <div class="display-field"><%: Model.NombreRegalo %></div>
        
        <div class="display-label">Precio</div>
        <div class="display-field"><%: String.Format("{0:F}", Model.Precio) %></div>
        
        <div class="display-label">Imagen</div>
        <div class="display-field"><%: Model.Imagen %></div>
        
        <div class="display-label">CategoriasIdCategoria</div>
        <div class="display-field"><%: Model.Categorias.NombreCategoria %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

