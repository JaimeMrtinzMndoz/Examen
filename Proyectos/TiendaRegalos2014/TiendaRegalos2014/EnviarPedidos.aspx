<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra/Maestra.Master" AutoEventWireup="true" CodeBehind="EnviarPedidos.aspx.cs" Inherits="TiendaRegalos2014.EnviarPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphBody" runat="server">
    <asp:GridView ID="gvPedidos" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" onprerender="gvPedidos_PreRender" 
        onrowcommand="gvPedidos_RowCommand">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="marcarEnviado" 
                Text="Marcar como enviado" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
</asp:Content>
