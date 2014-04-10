using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAccesoADatos.Controllers
{
    public class PersonasController : Controller
    {
        // Definimos aquí el objeto de nuestra entidad para 
        // usarlo en todos los métodos
        private DBPersonasEntities db = new DBPersonasEntities();

        //
        // GET: /Personas/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Demo/List

        public ActionResult List()
        {
            // Automáticamente aparecerá nuestra vista List. 
            // Le pasamos todos los usuarios
            return View(db.Personas.ToList());
        }

        //
        // GET: /Personas/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Personas/Create

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {
                db.Personas.AddObject(persona);
                db.SaveChanges();
                // Después de guardar volvemos al índice
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Personas/Edit/5
 
        public ActionResult Edit(int id)
        {
            Persona persona = 
                db.Personas.Single(p => p.IdPersona == id);
            return View(persona);
        }

        //
        // POST: /Personas/Edit/5

        [HttpPost]
        public ActionResult Edit(Persona persona)
        {
            try
            {
                db.Personas.Attach(persona);
                db.ObjectStateManager.ChangeObjectState
                    (persona, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(persona);
            }
        }

        //
        // GET: /Personas/Delete/5
 
        public ActionResult Delete(int id)
        {
            Persona persona = db.Personas.Single(p => p.IdPersona == id);
            return View(persona);
        }

        //
        // POST: /Personas/Delete/5


        // Aquí el argumento lo tengo como long porque si se define como int
        // la sobrecarga da error al tener dos métodos con nombes y argumentos
        // iguales

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Persona persona =
                    db.Personas.Single(p => p.IdPersona == id);
                db.Personas.DeleteObject(persona);
                db.SaveChanges();
                // Después de borrar volvemos al menú de opciones
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
