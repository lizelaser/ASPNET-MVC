using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmpleadosEDM.Models;

namespace EmpleadosEDM.Controllers
{
    public class Empleado_Experiencia_EstadisticasController : Controller
    {
        private AplicacionEDMEntitiess db = new AplicacionEDMEntitiess();

        // GET: Empleado_Experiencia_Estadisticas
        public ActionResult Index()
        {
            var empleado_Experiencia_Estadisticas = db.Empleado_Experiencia_Estadisticas.Include(e => e.Empleado);
            return View(empleado_Experiencia_Estadisticas.ToList());
        }

        // GET: Empleado_Experiencia_Estadisticas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas = db.Empleado_Experiencia_Estadisticas.Find(id);
            if (empleado_Experiencia_Estadisticas == null)
            {
                return HttpNotFound();
            }
            return View(empleado_Experiencia_Estadisticas);
        }

        // GET: Empleado_Experiencia_Estadisticas/Create
        public ActionResult Create()
        {
            ViewBag.idEmpleado = new SelectList(db.Empleados, "idEmpleado", "Nombre");
            return View();
        }

        // POST: Empleado_Experiencia_Estadisticas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idExperiencia,idEmpleado,Nombre,Anios,Bajas_Laborales")] Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas)
        {
            if (ModelState.IsValid)
            {
                db.Empleado_Experiencia_Estadisticas.Add(empleado_Experiencia_Estadisticas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idEmpleado = new SelectList(db.Empleados, "idEmpleado", "Nombre", empleado_Experiencia_Estadisticas.idEmpleado);
            return View(empleado_Experiencia_Estadisticas);
        }

        // GET: Empleado_Experiencia_Estadisticas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas = db.Empleado_Experiencia_Estadisticas.Find(id);
            if (empleado_Experiencia_Estadisticas == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEmpleado = new SelectList(db.Empleados, "idEmpleado", "Nombre", empleado_Experiencia_Estadisticas.idEmpleado);
            return View(empleado_Experiencia_Estadisticas);
        }

        // POST: Empleado_Experiencia_Estadisticas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idExperiencia,idEmpleado,Nombre,Anios,Bajas_Laborales")] Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado_Experiencia_Estadisticas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idEmpleado = new SelectList(db.Empleados, "idEmpleado", "Nombre", empleado_Experiencia_Estadisticas.idEmpleado);
            return View(empleado_Experiencia_Estadisticas);
        }

        // GET: Empleado_Experiencia_Estadisticas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas = db.Empleado_Experiencia_Estadisticas.Find(id);
            if (empleado_Experiencia_Estadisticas == null)
            {
                return HttpNotFound();
            }
            return View(empleado_Experiencia_Estadisticas);
        }

        // POST: Empleado_Experiencia_Estadisticas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado_Experiencia_Estadisticas empleado_Experiencia_Estadisticas = db.Empleado_Experiencia_Estadisticas.Find(id);
            db.Empleado_Experiencia_Estadisticas.Remove(empleado_Experiencia_Estadisticas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
