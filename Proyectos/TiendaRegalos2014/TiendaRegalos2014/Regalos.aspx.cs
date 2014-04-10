using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using TiendaRegalosDAO;

namespace TiendaRegalos2014
{
    public partial class Regalos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink lnkActivo = (HyperLink)this.Master.FindControl("linkRegalos");
                lnkActivo.CssClass = "active";
        }

        protected void cmdAgegar_Click(object sender, EventArgs e)
        {
            //Capturamos en nombre de la imagen
            string nombreArchivo = 
                Path.GetFileName(fupImagen.FileName);
            try
            {
                decimal precio = decimal.Parse(txtPrecio.Text);
                string nombre = txtNombre.Text;
                string imagen = "~/Imagenes/" + nombreArchivo;
                int idCat =
                    int.Parse(cmbCategorias2.SelectedValue); 
                //SelectedValue devuelve un string

                Regalo nuevoRegalo;
                nuevoRegalo = 
                    Regalo.nuevoRegalo(nombre, precio, imagen, 
                    idCat);
                nuevoRegalo.insertarRegalo();
                // Este método está en la clase parcial Regalo. 
                Response.Write("<script>alert('Regalo agregado a la tabla');</script>");
                //Subimos al servidor la imagen
                fupImagen.SaveAs
                    (Server.MapPath("~/Imagenes/" + nombreArchivo));

                //Refrescamos el gridview
                gvRegalos.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("Errores.aspx?fallo=error en el intento de agregado. " 
                    + ex.Message);
            }
        }

        protected void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                Regalo nuevoRegalo;
                nuevoRegalo = Regalo.getRegalo(id);
                string imagen = nuevoRegalo.Imagen;
                nuevoRegalo.borrarRegalo();
                Response.Write("<script>alert('Regalo eliminado de la tabla');</script>");
                //Este método está en la clase parcial Regalo. 
                //Borramos la imagen del servidor
                if (imagen != null)
                    File.Delete(Server.MapPath(imagen));
                gvRegalos.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect
                    ("Errores.aspx?fallo=error en el intento de eliminación " + ex.Message);
            }
        }
    }
}