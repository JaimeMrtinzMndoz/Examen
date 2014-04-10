using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace AplicacionPersonas3capas
{
    public partial class PersonasSQL : System.Web.UI.Page
    {
        SqlConnection con = 
            new SqlConnection("Data Source=LUKY1\\SQLEXPRESS;Initial Catalog=DBPersonas;Integrated Security=True;Pooling=False");
        SqlCommand comando;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Visualización de información del usuario.
            lblUsuario.Text = "Bienvenido, " + User.Identity.Name;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBPersonasConnectionString"].ConnectionString);
        }

        protected void cmdAgregar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(txtID.Text);
            string nombrePersona = txtNombre.Text;
            string ciudad = txtCiudad.Text;
            string sentencia = "Insert into Personas values (" + idPersona +
                ",'" + nombrePersona + "','" + ciudad + "')";
            comando = new SqlCommand(sentencia, con);
            try
            {
                con.Open();
                comando.ExecuteNonQuery();
                Response.Write("<script>alert ('Persona agregada a la tabla');</script>");
            }
            catch
            {
                Response.Write("<script>alert ('Error en el proceso de alta');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            int idPersona = int.Parse(txtID2.Text);
            string sentencia = "Delete from Personas where IdPersona=" + idPersona;
            comando = new SqlCommand(sentencia, con);
            try
            {
                con.Open();
                int eliminados=comando.ExecuteNonQuery();
                if (eliminados==0)
                    Response.Write("<script>alert('Persona inexistente');</script>");
                else
                    Response.Write("<script>alert('Persona eliminada de la tabla');</script>");
            }
            catch
            {
                Response.Write("<script>alert('Error en el proceso de eliminación');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void cmdConsultaCiudad_Click(object sender, EventArgs e)
        {
            string sentencia="Select * from Personas where ciudad='" + txtCiudad2.Text + "'";
            SqlDataAdapter personas = new SqlDataAdapter(sentencia, con);
            DataSet dsPersonas = new DataSet();
            personas.Fill(dsPersonas, "Personas");
            gvConsultaCiudad.DataSource = dsPersonas;
            gvConsultaCiudad.DataBind();
        }

        protected void cmdActualizar_Click(object sender, EventArgs e)
        {
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