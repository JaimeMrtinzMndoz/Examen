using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAOPersonas;
using System.Web.Security;

namespace AplicacionPersonas3capas
{
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            // Visualización de información del usuario.
            lblUsuario.Text = "Bienvenido, " + User.Identity.Name;
        }

        protected void cmdAgregar_Click(object sender, EventArgs e)
        {
            DBPersonasEntities db =
                new DBPersonasEntities();
            Persona nuevaPersona = new Persona();
            nuevaPersona.IdPersona = int.Parse(txtID.Text);
            nuevaPersona.NombrePersona = txtNombre.Text;
            nuevaPersona.Ciudad = txtCiudad.Text;
            try
            {
                //db.AddToPersonas(nuevaPersona);
                db.AddObject("Personas", nuevaPersona);
                db.SaveChanges();
                Response.Write("<script>alert('Persona agregada a la tabla');</script>");
            }
            catch
            {
                Response.Write("<script>alert('Error en el proceso de alta');</script>");
            }
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            DBPersonasEntities db =
                new DBPersonasEntities();
            int id = int.Parse(txtID2.Text);
            try
            {
                Persona elegidaPersona =
                    db.Personas.SingleOrDefault(p => p.IdPersona == id);
                db.DeleteObject(elegidaPersona);
                db.SaveChanges();
                Response.Write("<script>alert('Persona eliminada de la tabla');</script>");
            }
            catch
            {
                Response.Write("<script>alert('Error en el proceso de eliminación');</script>");
            }
        }

        protected void cmdConsultaCiudad_Click(object sender, EventArgs e)
        {
            List<Persona> personas =
                Persona.getPersonasSegunCiudad(txtCiudad2.Text);
            gvConsultaCiudad.DataSource = personas;
            gvConsultaCiudad.DataBind();
        }

        protected void cmdActualizar_Click(object sender, EventArgs e)
        {
            dsPersonas.DataBind();
            gvPersonas.DataBind();
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            // Desconexión del usuario
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

    }
}