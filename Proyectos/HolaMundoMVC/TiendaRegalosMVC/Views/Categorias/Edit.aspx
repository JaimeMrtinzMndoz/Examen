<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TiendaRegalosMVC.Models.Categoria>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCategoria) %>
            </div>
           
            <div class="editor-label">
                <%: Html.TextBoxFor(model => model.IdCategoria,new Dictionary<string, object>(){{"readonly", "true"}}) %>
            </div>
      
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NombreCategoria) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NombreCategoria) %>
                <%: Html.ValidationMessageFor(model => model.NombreCategoria) %>
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

