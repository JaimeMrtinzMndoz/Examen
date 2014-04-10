using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaRegalosDAO
{
    public partial class Regalo
    {
        static TiendaRegalosEntities tienda = 
            new TiendaRegalosEntities();

        // Este método devuelve el regalo según el 
        // id especificado
        public static Regalo getRegalo(int aIdRegalo)
        {
            return (from oRegalo in tienda.Regalos
                    where oRegalo.IdRegalo == aIdRegalo
                    select oRegalo).FirstOrDefault();
        }

        // Este método devuelve los regalos según 
        // la categoría especificada
        public static List<Regalo> getRegalos(int aIdCategoria)
        {
            return (from oRegalo in tienda.Regalos
                    where oRegalo.CategoriasIdCategoria == aIdCategoria
                    select oRegalo).ToList();
        }

        // Este método devuelve los regalos cuyo nombre 
        // contiene un texto (como el like en SQL)
        public static List<Regalo> getRegalos(string aContiene)
        {
            return (from oRegalo in tienda.Regalos
                    where oRegalo.NombreRegalo.Contains(aContiene)
                    select oRegalo).ToList();
        }

        // Este método devuelve todos los regalos a una lista
        public static List<Regalo> getRegalos()
        {
            return (from oRegalo in tienda.Regalos
                    select oRegalo).ToList();
        }

        // Este método crea un nuevo regalo sin incluir el id
        public static Regalo nuevoRegalo
            (string nombreRegalo, decimal precio, 
            string rutaImagen, int categoria)
        {
            Regalo regalo = new Regalo();
            // El id no lo incluyo porque es autonumérico
            regalo.NombreRegalo = nombreRegalo;
            regalo.Precio = precio;
            regalo.Imagen = rutaImagen;
            regalo.CategoriasIdCategoria = categoria;
            return regalo;
        }

        public void insertarRegalo()
        {
            tienda.AddObject("Regalos", this);
            tienda.SaveChanges();
        }

        public void borrarRegalo()
        {
            tienda.DeleteObject(this);
            tienda.SaveChanges();
        }
    }
}
