using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaRegalosDAO
{
    public partial class Cliente
    {
        static TiendaRegalosEntities tienda = 
            new TiendaRegalosEntities();

        // Este método devuelve el Cliente según 
        // el id especificado
        public static Cliente getCliente(int aIdCliente)
        {
            return (from oCliente in tienda.Clientes
                    where oCliente.IdCliente == aIdCliente
                    select oCliente).FirstOrDefault();
        }

        // Este método devuelve los clientes según 
        // la ciudad especificada
        public static List<Cliente> 
            getClienteCiudad(string aCiudad)
        {
            return (from oCliente in tienda.Clientes
                    where oCliente.Ciudad == aCiudad
                    select oCliente).ToList();
        }

        // Este método devuelve los Clientes cuyo 
        // nombre contiene un texto (como el like en SQL)
        public static List<Cliente> 
            getClientes(string aContiene)
        {
            return (from oCliente in tienda.Clientes
                    where oCliente.NombreCliente.Contains(aContiene)
                    select oCliente).ToList();
        }

        // Este método devuelve todos los Clientes a una lista
        public static List<Cliente> getClientes()
        {
            return (from oCliente in tienda.Clientes
                    select oCliente).ToList();
        }
    }
}
