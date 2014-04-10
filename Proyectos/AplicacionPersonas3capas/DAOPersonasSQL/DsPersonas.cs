using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAOPersonasSQL
{
    public class DsPersonas
    {
        public static DataSet dataSetPersonas()
        {
            SqlDataAdapter Personas = 
                new SqlDataAdapter("Select * from Personas", ConexionPersonas.conexionPersonas());
            DataSet dsPersonas = new DataSet();
            Personas.Fill(dsPersonas, "Personas");
            return dsPersonas;
        }

        public static DataSet dataSetPersonasDeCiudad(string ciudad)
        {
            string sentencia = "Select * from Personas where ciudad='" + ciudad + "'";
            SqlDataAdapter Personas = new SqlDataAdapter(sentencia, 
                ConexionPersonas.conexionPersonas());
            DataSet dsPersonas=new DataSet();
            Personas.Fill(dsPersonas, "Personas");
            return dsPersonas;
        }

        public static int insertarPersona(int id, string nombre, string ciudad)
        {
            string sentencia="Insert into Personas values (" + id +
                ",'" + nombre + "','" + ciudad + "')";
            SqlConnection con = ConexionPersonas.conexionPersonas();
            SqlCommand comando = new SqlCommand(sentencia, con);
            try
            {
                con.Open();
                int total = comando.ExecuteNonQuery();
                return total;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public static int eliminarPersona(int id)
        {
            string sentencia = "Delete from Personas where IdPersona=" + id;
            SqlConnection con = ConexionPersonas.conexionPersonas();
            SqlCommand comando = new SqlCommand(sentencia, con);
            try
            {
                con.Open();
                int total = comando.ExecuteNonQuery();
                return total;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
