using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAOPersonasSQL
{
    public class ConexionPersonas
    {
        public static SqlConnection conexionPersonas()
        {
            return new SqlConnection("Data Source=º-PC\\SQLEXPRESS;Initial Catalog=DBPersonas;Integrated Security=True;Pooling=False");
        }
    }
}
