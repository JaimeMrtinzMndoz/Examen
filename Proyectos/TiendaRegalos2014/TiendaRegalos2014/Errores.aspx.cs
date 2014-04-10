using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaRegalos2014
{
    public partial class Errores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = "Se ha producido el error: "
                            + Request.QueryString["fallo"];
        }
    }
}