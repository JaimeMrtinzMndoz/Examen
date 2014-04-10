using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaRegalosMVC.Models;
using System.Data; 

namespace TiendaRegalosMVC.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        //
        // GET: /Categorias/
        private TiendaRegalosEntities db =
            new TiendaRegalosEntities();

        public ActionResult Index()
        {
            // Pasamos a la vista (la vista lo captura en el Model) la lista de categorias
            return View(db.Categorias.ToList());
        }


        //
        // GET: /Categorias/Create

        public ActionResult Create()
        {
            // Cuando accedemos por una petición normal 
            // simplemente sacamos la vista
            return View();
        }

        //
        // POST: /Categorias/Create

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            // Aquí y en el resto de validaciones la validación funciona bien.
            // Como es del lado del servidor el código da una advertencia cuando 
            // el usuario no introduce bien los datos no es un error sino una 
            // advertencia, pero como estamos en modo de depuración
            // la aplicación parece que se detiene pero no es así. 
            // Cuando se detenga, volver a darle al play
            // y fijarse como en el navegador señala en rojo los errores al 
            // usuario.
            try
            {
                if (ModelState.IsValid)
                {
                    // Cuando hemos venido hasta aquí es porque se ha hecho una 
                    // petición POST y el contenido se ha dado por bueno.
                    db.Categorias.AddObject(categoria);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                // Si no se ha validado bien volvemos a la vista Create pasando los 
                // datos que ha puesto el usuario para revisión
                return View(categoria);
            }
            catch
            {
                return View(categoria);
            }
        }

        // GET: /Categorias/Edit/5
        // Las explicaciones de los métodos Edit serían las mismas que las
        // de los métodos Delete
        public ActionResult Edit(int id)
        {
            Categoria categoria =
                db.Categorias.Single(c => c.IdCategoria == id);

            return View(categoria);
        }

        //
        // POST: /Categorias/Edit/5

        [HttpPost]
        public ActionResult Edit(Categoria categoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Categorias.Attach(categoria);
                    db.ObjectStateManager.ChangeObjectState
                        (categoria, EntityState.Modified);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(categoria);
            }
            catch
            {
                return View(categoria);
            }
        }

        // GET: /Categorias/Delete/5

        public ActionResult Delete(int id)
        {
            // Desde la vista Index llegamos hasta aquí pulsando en el 
            // Link Delete. El código de la vista es:
            // <%: Html.ActionLink("Eliminar", "Delete", new { id=item.IdCategoria })%>
            // Recibimos aquí en id el id de la categoria a eliminar.
            // En la línea de código de abajo capturamos la categoría con ese 
            // id, la mostramos en la vista y volvemos al controlador
            // por POST pasándole la categoría a eliminar.
            // Esa petición POST la recogerá el método siguiente.
            Categoria categoria =
                db.Categorias.Single(c => c.IdCategoria == id);
            return View(categoria);
        }

        //
        // POST: /Categorias/Delete/5

        [HttpPost, ActionName("Delete")]
        //Aquí llegamos cuando pulsamos el botón final de eliminación
        //Se captura la categoría según el id que recogemos
        //Se recoge automáticamente porque en la barra de 
        //direcciones el id "viaja" desde que en la lista de 
        //categorías en una de ella le damos a eliminar
        //aparece /Categorias/Delete/x siendo x el id de la 
        //categoría que hemos pinchado.

        public ActionResult DeleteConfirmed(int id)
        {
            Categoria categoria = db.Categorias.Single
                (c => c.IdCategoria == id);
            db.Categorias.DeleteObject(categoria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
