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
    public class ASOCIACIONsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ASOCIACIONs
        public ActionResult Index()
        {
            return View(db.ASOCIACION.ToList());
        }

        // GET: ASOCIACIONs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASOCIACION aSOCIACION = db.ASOCIACION.Find(id);
            if (aSOCIACION == null)
            {
                return HttpNotFound();
            }
            return View(aSOCIACION);
        }

        // GET: ASOCIACIONs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASOCIACIONs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ASO_ID,ASO_NOMBRE")] ASOCIACION aSOCIACION)
        {
            if (ModelState.IsValid)
            {
                db.ASOCIACION.Add(aSOCIACION);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aSOCIACION);
        }

        // GET: ASOCIACIONs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASOCIACION aSOCIACION = db.ASOCIACION.Find(id);
            if (aSOCIACION == null)
            {
                return HttpNotFound();
            }
            return View(aSOCIACION);
        }

        // POST: ASOCIACIONs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ASO_ID,ASO_NOMBRE")] ASOCIACION aSOCIACION)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aSOCIACION).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aSOCIACION);
        }

        // GET: ASOCIACIONs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASOCIACION aSOCIACION = db.ASOCIACION.Find(id);
            if (aSOCIACION == null)
            {
                return HttpNotFound();
            }
            return View(aSOCIACION);
        }

        // POST: ASOCIACIONs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ASOCIACION aSOCIACION = db.ASOCIACION.Find(id);
            db.ASOCIACION.Remove(aSOCIACION);
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
