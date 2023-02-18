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
    public class AFICIONsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AFICIONs
        public ActionResult Index()
        {
            return View(db.AFICION.ToList());
        }

        // GET: AFICIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AFICION aFICION = db.AFICION.Find(id);
            if (aFICION == null)
            {
                return HttpNotFound();
            }
            return View(aFICION);
        }

        // GET: AFICIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AFICIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AFI_ID,AFI_NOMBRE")] AFICION aFICION)
        {
            if (ModelState.IsValid)
            {
                db.AFICION.Add(aFICION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aFICION);
        }

        // GET: AFICIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AFICION aFICION = db.AFICION.Find(id);
            if (aFICION == null)
            {
                return HttpNotFound();
            }
            return View(aFICION);
        }

        // POST: AFICIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AFI_ID,AFI_NOMBRE")] AFICION aFICION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aFICION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aFICION);
        }

        // GET: AFICIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AFICION aFICION = db.AFICION.Find(id);
            if (aFICION == null)
            {
                return HttpNotFound();
            }
            return View(aFICION);
        }

        // POST: AFICIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AFICION aFICION = db.AFICION.Find(id);
            db.AFICION.Remove(aFICION);
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
