﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace TiendaRegalos2014
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool bUsuarioAutenticado;

            bUsuarioAutenticado =
                HttpContext.Current.User.Identity.IsAuthenticated;

            DivMenu.Visible = bUsuarioAutenticado;
            lnkCerrarSesion.Visible = bUsuarioAutenticado;
            lblUsuario.Visible = bUsuarioAutenticado;
            if (bUsuarioAutenticado)
                lblUsuario.Text = "Bienvenido, " + HttpContext.Current.User.Identity.Name;
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}