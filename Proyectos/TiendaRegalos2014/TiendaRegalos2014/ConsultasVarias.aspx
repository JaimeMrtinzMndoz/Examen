<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra/Maestra.Master" AutoEventWireup="true" CodeBehind="ConsultasVarias.aspx.cs" Inherits="TiendaRegalos2014.ConsultasVarias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphBody" runat="server">
<table class="style4">
        <tr>
            <td >
                <asp:LinkButton ID="lnkListaClientes" runat="server" 
                    onclick="lnkListaClientes_Click">Lista de Clientes</asp:LinkButton>
            </td>
            <td >
                &nbsp;</td>
            <td >
                <asp:LinkButton ID="lnkClientesCuyoNombre" runat="server" 
                    onclick="lnkClientesCuyoNombre_Click">Clientes cuyo nombre contiene</asp:LinkButton>
            </td>
            <td >
                <asp:TextBox ID="txtNombreContiene" runat="server" Height="21px" Width="84px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                <asp:LinkButton ID="lnkClientesCiudad" runat="server" 
                    onclick="lnkClientesCiudad_Click">Clientes de una ciudad</asp:LinkButton>
            </td>
            <td >
                <asp:TextBox ID="txtCiudad" runat="server" Height="21px" Width="84px"></asp:TextBox>
            </td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:LinkButton ID="lnkPedidosMes" runat="server" 
                    onclick="lnkPedidosMes_Click">Pedidos de un mes</asp:LinkButton>
            </td>
            <td >
                <asp:TextBox ID="txtMes" runat="server" Height="21px" Width="84px"></asp:TextBox>
            </td>
            <td >
                <asp:LinkButton ID="lnkPedidosEnviados" runat="server" 
                    onclick="lnkPedidosEnviados_Click">Pedidos enviados</asp:LinkButton>
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:LinkButton ID="lnkPedidosCliente" runat="server" 
                    onclick="lnkPedidosCliente_Click">Pedidos de un cliente</asp:LinkButton>
            </td>
            <td >
                <asp:TextBox ID="txtIdCliente" runat="server" Height="21px" Width="84px"></asp:TextBox>
            </td>
            <td >
                <asp:LinkButton ID="lnkDetallesPedido" runat="server" 
                    onclick="lnkDetallesPedido_Click">Detalles de un pedido</asp:LinkButton>
            </td>
            <td >
                <asp:TextBox ID="txtIdPedido" runat="server" Height="21px" Width="84px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="gvConsultas" runat="server" BackColor="#DEBA84" 
                    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                    CellSpacing="2">
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
            </td>
        </tr>
    </table>
</asp:Content>
