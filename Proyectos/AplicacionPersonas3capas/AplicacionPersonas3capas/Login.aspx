<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AplicacionPersonas3capas.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                         style="width:150px;"></asp:TextBox>
            <asp:RequiredFieldValidator ID="TxtUsuario_RequiredFieldValidator"
                            runat="server"
                            ErrorMessage="Por favor, introduzca un usuario"
                            Text="*"
                            ControlToValidate="TxtUsuario" ForeColor="Red" />
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
                         style="width:130px; "></asp:TextBox>
            <asp:RequiredFieldValidator ID="TxtContrasena_RequiredFieldValidator"
                            runat="server"
                            ErrorMessage="Por favor, introduzca la contraseña"
                            Text="*"
                            ControlToValidate="TxtContrasena" ForeColor="Red" />
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
                       runat="server" />
    </div>
    </form>
</body>
</html>
