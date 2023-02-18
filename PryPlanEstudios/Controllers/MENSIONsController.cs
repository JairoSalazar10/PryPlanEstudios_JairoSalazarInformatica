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
    public class MENSIONsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MENSIONs
        public ActionResult Index()
        {
            return View(db.MENSION.ToList());
        }

        // GET: MENSIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENSION mENSION = db.MENSION.Find(id);
            if (mENSION == null)
            {
                return HttpNotFound();
            }
            return View(mENSION);
        }

        // GET: MENSIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MENSIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MEN_ID,MEN_NOMBRE")] MENSION mENSION)
        {
            if (ModelState.IsValid)
            {
                db.MENSION.Add(mENSION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mENSION);
        }

        // GET: MENSIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENSION mENSION = db.MENSION.Find(id);
            if (mENSION == null)
            {
                return HttpNotFound();
            }
            return View(mENSION);
        }

        // POST: MENSIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MEN_ID,MEN_NOMBRE")] MENSION mENSION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mENSION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mENSION);
        }

        // GET: MENSIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MENSION mENSION = db.MENSION.Find(id);
            if (mENSION == null)
            {
                return HttpNotFound();
            }
            return View(mENSION);
        }

        // POST: MENSIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MENSION mENSION = db.MENSION.Find(id);
            db.MENSION.Remove(mENSION);
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
