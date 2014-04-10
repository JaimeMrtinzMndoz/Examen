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
    public class RegalosController : Controller
    {
        private TiendaRegalosEntities
            db = new TiendaRegalosEntities();

        //
        // GET: /Regalos/

        public ActionResult Index()
        {
            return View(db.Regalos.ToList());
        }

        //
        // GET: /Regalos/Create

        public ActionResult Create()
        {
            // Con esto pasamos a la vista una lista de 
            // categorías para que saque un combo
            // con todas las categorías.
            ViewData["CategoriasIdCategoria"] =
                new SelectList(db.Categorias, "IdCategoria",
                    "NombreCategoria");
            return View();
        }

        //
        // POST: /Regalos/Create

        [HttpPost]
        public ActionResult Create(Regalo regalo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Regalos.AddObject(regalo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                // Cuando hay un error porque nos olvidamos de
                // introducir un dato o no seleccionamos ningún
                // elemento de la lista retornamos a la vista
                // pasando de nuevo los nombres de categoría
                // que la vista recogerá en el dropdownlist
                ViewData["CategoriasIdCategoria"] =
                    new SelectList(db.Categorias, "IdCategoria",
                        "NombreCategoria",
                         regalo.CategoriasIdCategoria);
                return View(regalo);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Regalos/Edit/5

        public ActionResult Edit(int id)
        {
            Regalo regalo = db.Regalos.Single
                (r => r.IdRegalo == id);

            ViewData["CategoriasIdCategoria"] =
                new SelectList(db.Categorias, "IdCategoria",
                    "NombreCategoria", regalo.CategoriasIdCategoria);
            return View(regalo);
        }

        //
        // POST: /Regalos/Edit/5

        [HttpPost]
        public ActionResult Edit(Regalo regalo)
        {
            if (ModelState.IsValid)
            {
                db.Regalos.Attach(regalo);
                db.ObjectStateManager.ChangeObjectState
                    (regalo, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["CategoriasIdCategoria"] =
                new SelectList(db.Categorias, "IdCategoria",
                    "NombreCategoria", regalo.CategoriasIdCategoria);
            return View(regalo);
        }

        //
        // GET: /Regalos/Delete/5

        public ActionResult Delete(int id)
        {
            Regalo regalo =
                db.Regalos.Single(r => r.IdRegalo == id);

            return View(regalo);
        }

        //
        // POST: /Regalos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Regalo regalo =
                db.Regalos.Single(r => r.IdRegalo == id);
            db.Regalos.DeleteObject(regalo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
