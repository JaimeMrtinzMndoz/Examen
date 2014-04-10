<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonasSQLClases.aspx.cs" Inherits="AplicacionPersonas3capas.PersonasSQLClases" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
        <br />
        <asp:LinkButton ID="lnkCerrarSesion" runat="server" 
            onclick="lnkCerrarSesion_Click">Cerrar sesión</asp:LinkButton>
        <br />
        <br />
     <table>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" Text="Id Persona"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" Width="43px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label3" runat="server" Text="Ciudad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="cmdAgregar" runat="server" onclick="cmdAgregar_Click" 
                        Text="Agregar nueva persona" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label4" runat="server" Text="Id Persona"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID2" runat="server" Width="43px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="cmdEliminar" runat="server" onclick="cmdEliminar_Click" 
                        Text="Eliminar persona por ID" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label5" runat="server" Text="Ciudad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCiudad2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Button ID="cmdConsultaCiudad" runat="server" 
                        onclick="cmdConsultaCiudad_Click" Text="Ejecutar consulta ciudad" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:GridView ID="gvConsultaCiudad" runat="server" CellPadding="4" 
                        ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="Personas"></asp:Label>
&nbsp;
                    <asp:Button ID="cmdActualizar" runat="server" onclick="cmdActualizar_Click" 
                        Text="Actualizar" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" DataKeyNames="IdPersona" DataSourceID="dsPersonas" 
                        ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="IdPersona" HeaderText="IdPersona" ReadOnly="True" 
                                SortExpression="IdPersona" />
                            <asp:BoundField DataField="NombrePersona" HeaderText="NombrePersona" 
                                SortExpression="NombrePersona" />
                            <asp:BoundField DataField="Ciudad" HeaderText="Ciudad" 
                                SortExpression="Ciudad" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <asp:SqlDataSource ID="dsPersonas" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:DBPersonasConnectionString %>" 
                        SelectCommand="SELECT * FROM [Personas]"></asp:SqlDataSource>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
