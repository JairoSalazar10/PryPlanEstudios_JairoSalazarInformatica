using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using CapaNegocio.Entities;

namespace PryPlanEstudios.Controllers
{
    public class CARRERAsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CARRERAs
        public ActionResult Index()
        {
            var cARRERAs = db.CARRERAs.Include(c => c.FACULTAD);
            return View(cARRERAs.ToList());
        }

        // GET: CARRERAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRERA cARRERA = db.CARRERAs.Find(id);
            if (cARRERA == null)
            {
                return HttpNotFound();
            }
            return View(cARRERA);
        }

        // GET: CARRERAs/Create
        public ActionResult Create()
        {
            ViewBag.FAC_ID = new SelectList(db.FACULTAD, "FAC_ID", "FAC_NOMBRE");
            return View();
        }

        // POST: CARRERAs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CAR_ID,CAR_CODIGO,CAR_NOMBRE,FAC_ID")] CARRERA cARRERA)
        {
            if (ModelState.IsValid)
            {
                db.CARRERAs.Add(cARRERA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FAC_ID = new SelectList(db.FACULTAD, "FAC_ID", "FAC_NOMBRE", cARRERA.FAC_ID);
            return View(cARRERA);
        }

        // GET: CARRERAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRERA cARRERA = db.CARRERAs.Find(id);
            if (cARRERA == null)
            {
                return HttpNotFound();
            }
            ViewBag.FAC_ID = new SelectList(db.FACULTAD, "FAC_ID", "FAC_NOMBRE", cARRERA.FAC_ID);
            return View(cARRERA);
        }

        // POST: CARRERAs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CAR_ID,CAR_CODIGO,CAR_NOMBRE,FAC_ID")] CARRERA cARRERA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cARRERA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FAC_ID = new SelectList(db.FACULTAD, "FAC_ID", "FAC_NOMBRE", cARRERA.FAC_ID);
            return View(cARRERA);
        }

        // GET: CARRERAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CARRERA cARRERA = db.CARRERAs.Find(id);
            if (cARRERA == null)
            {
                return HttpNotFound();
            }
            return View(cARRERA);
        }

        // POST: CARRERAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CARRERA cARRERA = db.CARRERAs.Find(id);
            db.CARRERAs.Remove(cARRERA);
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
