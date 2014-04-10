<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TiendaRegalosMVC.Models.Pedido>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Enviar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Enviar</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdPedido) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdPedido)%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaPedido) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FechaPedido, String.Format("{0:g}", Model.FechaPedido, new { @readonly = true }))%>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Importe) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Importe, String.Format("{0:c}", Model.Importe)) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ClientesIdCliente) %>
            </div>

            <%: Html.HiddenFor(model => model.FechaEnvio) %>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Clientes.NombreCliente)%>
            </div>
            
                        
            <p>
                <input type="submit" value="Marcar como enviado" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Volver atrás", "Index") %>
    </div>

</asp:Content>

