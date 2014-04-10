using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using DAOPersonasSQL;

namespace AplicacionPersonas3capas
{
    public partial class PersonasSQLClases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Visualización de información del usuario.
            lblUsuario.Text = "Bienvenido, " + User.Identity.Name;
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            // Desconexión del usuario
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void cmdActualizar_Click(object sender, EventArgs e)
        {
            gvPersonas.DataBind();
        }

        protected void cmdConsultaCiudad_Click(object sender, EventArgs e)
        {
            gvConsultaCiudad.DataSource =
                DsPersonas.dataSetPersonasDeCiudad(txtCiudad2.Text);
            gvConsultaCiudad.DataBind();
        }

        protected void cmdAgregar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(txtID.Text);
            string nombrePersona = txtNombre.Text;
            string ciudad = txtCiudad.Text;  
            int total=DsPersonas.insertarPersona(idPersona, nombrePersona, ciudad);
            if (total!=0)
                Response.Write("<script>alert('Persona agregada a la tabla');</script>");
            else
                Response.Write("<script>alert('Error en el proceso de alta');</script>");
            
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(txtID2.Text);
            int total = DsPersonas.eliminarPersona(idPersona);
            if (total != 0)
                Response.Write("<script>alert('Persona eliminada de la tabla');</script>");
            else
                Response.Write("<script>alert('Error en el proceso de eliminación');</script>");
        }
    }
}