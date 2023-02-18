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
    public class PLANsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PLANs
        public ActionResult Index()
        {
            var pLAN = db.PLAN.Include(p => p.CARRERA);
            return View(pLAN.ToList());
        }

        // GET: PLANs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN pLAN = db.PLAN.Find(id);
            if (pLAN == null)
            {
                return HttpNotFound();
            }
            return View(pLAN);
        }

        // GET: PLANs/Create
        public ActionResult Create()
        {
            ViewBag.CAR_ID = new SelectList(db.CARRERAs, "CAR_ID", "CAR_NOMBRE");
            return View();
        }

        // POST: PLANs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PLA_ID,PLA_CODIGO,PLA_NOMBRE,CAR_ID")] PLAN pLAN)
        {
            if (ModelState.IsValid)
            {
                db.PLAN.Add(pLAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CAR_ID = new SelectList(db.CARRERAs, "CAR_ID", "CAR_NOMBRE", pLAN.CAR_ID);
            return View(pLAN);
        }

        // GET: PLANs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN pLAN = db.PLAN.Find(id);
            if (pLAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.CAR_ID = new SelectList(db.CARRERAs, "CAR_ID", "CAR_NOMBRE", pLAN.CAR_ID);
            return View(pLAN);
        }

        // POST: PLANs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PLA_ID,PLA_CODIGO,PLA_NOMBRE,CAR_ID")] PLAN pLAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pLAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CAR_ID = new SelectList(db.CARRERAs, "CAR_ID", "CAR_NOMBRE", pLAN.CAR_ID);
            return View(pLAN);
        }

        // GET: PLANs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN pLAN = db.PLAN.Find(id);
            if (pLAN == null)
            {
                return HttpNotFound();
            }
            return View(pLAN);
        }

        // POST: PLANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PLAN pLAN = db.PLAN.Find(id);
            db.PLAN.Remove(pLAN);
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
