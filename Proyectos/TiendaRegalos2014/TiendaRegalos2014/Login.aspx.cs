using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TiendaRegalos2014
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CmdConectar_Click(object sender, EventArgs e)
        {
            bool bUsuarioExiste;

            if (this.IsValid)
            {
                // Identificación
                bUsuarioExiste =
                    Membership.ValidateUser(TxtUsuario.Text, TxtContrasena.Text);

                if (bUsuarioExiste)
                {
                    FormsAuthentication.RedirectFromLoginPage
                        (TxtUsuario.Text, false);
                }
                else
                {
                    // Ejecutamos el script js alert para avisar del error
                    Response.Write
                        ("<SCRIPT LANGUAGE='JavaScript'>alert('Usuario y/o contraseña erróneos')</SCRIPT>");
                }
            }
        }
    }
}