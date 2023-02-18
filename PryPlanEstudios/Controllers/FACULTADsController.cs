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
    public class FACULTADsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FACULTADs
        public ActionResult Index()
        {
            return View(db.FACULTAD.ToList());
        }

        // GET: FACULTADs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACULTAD fACULTAD = db.FACULTAD.Find(id);
            if (fACULTAD == null)
            {
                return HttpNotFound();
            }
            return View(fACULTAD);
        }

        // GET: FACULTADs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FACULTADs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FAC_ID,FAC_CODIGO,FAC_NOMBRE")] FACULTAD fACULTAD)
        {
            if (ModelState.IsValid)
            {
                db.FACULTAD.Add(fACULTAD);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fACULTAD);
        }

        // GET: FACULTADs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACULTAD fACULTAD = db.FACULTAD.Find(id);
            if (fACULTAD == null)
            {
                return HttpNotFound();
            }
            return View(fACULTAD);
        }

        // POST: FACULTADs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FAC_ID,FAC_CODIGO,FAC_NOMBRE")] FACULTAD fACULTAD)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fACULTAD).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fACULTAD);
        }

        // GET: FACULTADs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FACULTAD fACULTAD = db.FACULTAD.Find(id);
            if (fACULTAD == null)
            {
                return HttpNotFound();
            }
            return View(fACULTAD);
        }

        // POST: FACULTADs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FACULTAD fACULTAD = db.FACULTAD.Find(id);
            db.FACULTAD.Remove(fACULTAD);
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
