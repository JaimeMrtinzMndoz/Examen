using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaRegalosDAO
{
    public partial class Usuario
    {
         static TiendaRegalosEntities tienda
            = new TiendaRegalosEntities(); 
        public static Usuario getUsuario(string aNombre, string aContrasena)
        {
            return (from oUsuario in tienda.Usuarios
                    where oUsuario.Nombre == aNombre
                    && oUsuario.Contrasena == aContrasena
                    select oUsuario).FirstOrDefault();
        }
    }
}
