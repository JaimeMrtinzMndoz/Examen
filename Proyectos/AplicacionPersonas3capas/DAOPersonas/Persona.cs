using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOPersonas
{
    public partial class Persona
    {
        // Este método devuelve las pesonas según la ciudad especificada
        // aCiudad lo comienzo por a por argument y oPersona por o por object.
        // Los nombres puedes ser otros.
        public static List<Persona> getPersonasSegunCiudad(string aCiudad)
        {
            // Necesitamos un objeto que represente al contenedor de las entidades 
            // Por eso creamos oPersonas
            DBPersonasEntities oPersonas = new DBPersonasEntities();
            return (from oPersona in oPersonas.Personas
                    where oPersona.Ciudad == aCiudad
                    select oPersona).ToList();
        }
    }

}
