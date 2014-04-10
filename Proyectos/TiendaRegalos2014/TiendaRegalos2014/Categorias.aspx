<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra/Maestra.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="TiendaRegalos2014.Categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphBody" runat="server">
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
        AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
        DataKeyNames="IdCategoria" DataSourceID="dsCategorias" Height="50px" 
        Width="303px">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="IdCategoria" HeaderText="IdCategoria" 
                ReadOnly="True" SortExpression="IdCategoria" />
            <asp:BoundField DataField="NombreCategoria" HeaderText="NombreCategoria" 
                SortExpression="NombreCategoria" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowInsertButton="True" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <asp:EntityDataSource ID="dsCategorias" runat="server" 
        ConnectionString="name=TiendaRegalosEntities" 
        DefaultContainerName="TiendaRegalosEntities" EnableDelete="True" 
        EnableFlattening="False" EnableInsert="True" EnableUpdate="True" 
        EntitySetName="Categorias">
    </asp:EntityDataSource>
</asp:Content>
