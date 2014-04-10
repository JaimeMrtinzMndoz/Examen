using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaRegalosDAO
{
    public partial class Categoria
    {
        static TiendaRegalosEntities tienda
            = new TiendaRegalosEntities(); 
        //Este método devuelve la categoría según el id especificado
        //aIdCategoria lo comienzo por a por argument y
        //oCategoria por o por object.
        //Los nombres puedes ser otros.
        public static Categoria getCategoria(int aIdCategoria)
        {
            return (from oCategoria in tienda.Categorias
                    where oCategoria.IdCategoria == aIdCategoria
                    select oCategoria).FirstOrDefault();
        }

        // Este método devuelve todas las categorías a una lista
        public static List<Categoria> getListaCategorias()
        {
            return (from oCategoria in tienda.Categorias
                    select oCategoria).ToList();
        }
    }
}
