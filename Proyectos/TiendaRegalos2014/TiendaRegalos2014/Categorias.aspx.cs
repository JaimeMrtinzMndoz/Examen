using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaRegalos2014
{
    public partial class Categorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink lnkActivo =
                    (HyperLink)this.Master.FindControl("linkCategorias");
            lnkActivo.CssClass = "active";
        }
    }
}