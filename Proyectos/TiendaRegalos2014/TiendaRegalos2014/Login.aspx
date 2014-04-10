<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra/Maestra.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TiendaRegalos2014.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CphBody" runat="server">
<table class="CentrarContenedor">
    <col style="width:125px; " />
    <col style="width:250px; " />

    <tr>
        <td>
            <asp:Label ID="Label1" runat="server"
                       Text="Usuario:"
                       AssociatedControlID="TxtUsuario"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtUsuario"
                         runat="server"
                         style="width:150px; text-transform:none;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="TxtUsuario_RequiredFieldValidator"
                            runat="server"
                            ErrorMessage="Por favor, introduzca un usuario"
                            Text="*"
                            ControlToValidate="TxtUsuario" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server"
                       Text="Contraseña:"
                       AssociatedControlID="TxtContrasena"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtContrasena"
                         runat="server"
                         TextMode="Password"
                         style="width:130px;text-transform:none; "></asp:TextBox>
            <asp:RequiredFieldValidator ID="TxtContrasena_RequiredFieldValidator"
                            runat="server"
                            ErrorMessage="Por favor, introduzca la contraseña"
                            Text="*"
                            ControlToValidate="TxtContrasena" />
        </td>
    </tr>
    <tr>
        <td colspan="2"
            style="text-align:center; padding-top:10px; ">
            <asp:Button ID="CmdConectar"
                        runat="server"
                        Text="Aceptar"
                        style="width:100px; "
                        onclick="CmdConectar_Click" />

        </td>
    </tr>
</table>
<br />
<br />

<asp:ValidationSummary ID="ResumenValidacionDatos"
                       runat="server"
                       Style="text-align: center; padding-top:15px;
padding-bottom:15px; " />
</asp:Content>
