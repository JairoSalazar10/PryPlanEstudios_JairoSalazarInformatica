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
    public class MOTIVACIONsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MOTIVACIONs
        public ActionResult Index()
        {
            return View(db.MOTIVACION.ToList());
        }

        // GET: MOTIVACIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTIVACION mOTIVACION = db.MOTIVACION.Find(id);
            if (mOTIVACION == null)
            {
                return HttpNotFound();
            }
            return View(mOTIVACION);
        }

        // GET: MOTIVACIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MOTIVACIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MOT_ID,MOT_NOMBRE")] MOTIVACION mOTIVACION)
        {
            if (ModelState.IsValid)
            {
                db.MOTIVACION.Add(mOTIVACION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mOTIVACION);
        }

        // GET: MOTIVACIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTIVACION mOTIVACION = db.MOTIVACION.Find(id);
            if (mOTIVACION == null)
            {
                return HttpNotFound();
            }
            return View(mOTIVACION);
        }

        // POST: MOTIVACIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MOT_ID,MOT_NOMBRE")] MOTIVACION mOTIVACION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOTIVACION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mOTIVACION);
        }

        // GET: MOTIVACIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOTIVACION mOTIVACION = db.MOTIVACION.Find(id);
            if (mOTIVACION == null)
            {
                return HttpNotFound();
            }
            return View(mOTIVACION);
        }

        // POST: MOTIVACIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOTIVACION mOTIVACION = db.MOTIVACION.Find(id);
            db.MOTIVACION.Remove(mOTIVACION);
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
