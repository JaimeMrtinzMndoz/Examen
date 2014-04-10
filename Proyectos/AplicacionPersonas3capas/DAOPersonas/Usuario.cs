using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOPersonas
{
    public partial class Usuario
    {
        public static Usuario getUsuario(string aNombre, string aContrasena)
        {
            DBPersonasEntities oPersonas = new DBPersonasEntities();
            return (from oUsuario in oPersonas.Usuarios
                    where oUsuario.Nombre == aNombre
                    && oUsuario.Contrasena == aContrasena
                    select oUsuario).FirstOrDefault();
        }
    }
}
