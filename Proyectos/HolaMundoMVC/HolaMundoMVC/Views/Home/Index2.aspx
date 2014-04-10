<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<HolaMundoMVC.Models.Usuario>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index2</title>
</head>
<body>
    <div>
         <%: Html.TextBoxFor(model => model.Nombre) %>
         <%: Html.TextBoxFor(model => model.Ciudad) %>
         <%: Html.TextBoxFor(model => model.FechaAlta) %>
         
         <br />
         <h2>Introduce tu edad</h2>
         <form method="post" action="Index2.aspx">
         <input type="text" name="edad" />
         <input type="submit" />
         </form>
    </div>
</body>
</html>
