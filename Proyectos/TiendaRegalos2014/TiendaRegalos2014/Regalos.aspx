<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra/Maestra.Master" AutoEventWireup="true" CodeBehind="Regalos.aspx.cs" Inherits="TiendaRegalos2014.Regalos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphBody" runat="server">
    <asp:EntityDataSource ID="dsRegalos" runat="server" 
        ConnectionString="name=TiendaRegalosEntities" 
        DefaultContainerName="TiendaRegalosEntities" EnableFlattening="False" 
        EntitySetName="Regalos" Where="it.CategoriasIdCategoria=@cat">
        <WhereParameters>
            <asp:ControlParameter ControlID="cmbCategorias" DbType="Int16" Name="cat" 
                PropertyName="SelectedValue" />
        </WhereParameters>
    </asp:EntityDataSource>
    <asp:DropDownList ID="cmbCategorias" runat="server" AutoPostBack="True" 
        DataSourceID="dsCategorias" DataTextField="NombreCategoria" 
        DataValueField="IdCategoria">
    </asp:DropDownList>
    <asp:EntityDataSource ID="dsCategorias" runat="server" 
        ConnectionString="name=TiendaRegalosEntities" 
        DefaultContainerName="TiendaRegalosEntities" EnableFlattening="False" 
        EntitySetName="Categorias">
    </asp:EntityDataSource>
    <asp:GridView ID="gvRegalos" runat="server" AutoGenerateColumns="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataSourceID="dsRegalos">
        <Columns>
            <asp:BoundField DataField="IdRegalo" HeaderText="IdRegalo" ReadOnly="True" 
                SortExpression="IdRegalo" />
            <asp:BoundField DataField="NombreRegalo" HeaderText="NombreRegalo" 
                SortExpression="NombreRegalo" />
            <asp:BoundField DataField="Precio" DataFormatString="{0:c}" HeaderText="Precio" 
                SortExpression="Precio" />
            <asp:ImageField DataImageUrlField="Imagen" HeaderText="Imagen">
                <ControlStyle Height="50px" Width="50px" />
            </asp:ImageField>
            <asp:BoundField DataField="CategoriasIdCategoria" 
                HeaderText="CategoriasIdCategoria" SortExpression="CategoriasIdCategoria" />
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
    <br />
    <table>
     <tr>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label4" runat="server" Text="Precio"></asp:Label>
            </td>
            <td >
                <asp:Label ID="Label5" runat="server" Text="Imagen"></asp:Label>
                </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Categoria"></asp:Label>
                </td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
            <td >
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            </td>
            <td >
                <asp:FileUpload ID="fupImagen" runat="server" Width="261px" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="fupImagen" 
        ErrorMessage="Sólo imágenes  .gif, .jpg, .png, .tiff and .jpeg" ForeColor="Red" 
        ValidationExpression="(.*\.([Gg][Ii][Ff])|.*\.([Jj][Pp][Gg])|.*\.([Bb][Mm][Pp])|.*\.([pP][nN][gG])|.*\.([tT][iI][iI][fF])$)">*</asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:DropDownList ID="cmbCategorias2" runat="server" 
                    DataSourceID="dsCategorias" DataTextField="NombreCategoria" 
                    DataValueField="IdCategoria">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td  colspan="2">
                <asp:Button ID="cmdAgegar" runat="server" onclick="cmdAgegar_Click" 
                    Text="Agregar regalo" />
            </td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Label ID="Label7" runat="server" Text="⁯Id Regalo"></asp:Label>
&nbsp;<asp:TextBox ID="txtId" runat="server" Width="83px"></asp:TextBox>
            </td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:Button ID="cmdEliminar" runat="server" onclick="cmdEliminar_Click" 
                    Text="Eliminar por Id" onclientclick="return confirm('¿Estás seguro?')" />
            </td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
            <td >
                &nbsp;</td>
            <td >
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
