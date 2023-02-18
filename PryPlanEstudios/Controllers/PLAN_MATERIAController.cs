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
    public class PLAN_MATERIAController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PLAN_MATERIA
        public ActionResult Index()
        {
            var pLAN_MATERIA = db.PLAN_MATERIA.Include(p => p.MATERIA).Include(p => p.PLAN);
            return View(pLAN_MATERIA.ToList());
        }

        // GET: PLAN_MATERIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN_MATERIA pLAN_MATERIA = db.PLAN_MATERIA.Find(id);
            if (pLAN_MATERIA == null)
            {
                return HttpNotFound();
            }
            return View(pLAN_MATERIA);
        }

        // GET: PLAN_MATERIA/Create
        public ActionResult Create()
        {
            ViewBag.MAT_ID = new SelectList(db.MATERIA, "MAT_ID", "MAT_NOMBRE");
            ViewBag.PLA_ID = new SelectList(db.PLAN, "PLA_ID", "PLA_NOMBRE");
            return View();
        }

        // POST: PLAN_MATERIA/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PLM_ID,PLA_ID,MAT_ID")] PLAN_MATERIA pLAN_MATERIA)
        {
            if (ModelState.IsValid)
            {
                db.PLAN_MATERIA.Add(pLAN_MATERIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MAT_ID = new SelectList(db.MATERIA, "MAT_ID", "MAT_NOMBRE");
            ViewBag.PLA_ID = new SelectList(db.PLAN, "PLA_ID", "PLA_NOMBRE");
            return View(pLAN_MATERIA);
        }

        // GET: PLAN_MATERIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN_MATERIA pLAN_MATERIA = db.PLAN_MATERIA.Find(id);
            if (pLAN_MATERIA == null)
            {
                return HttpNotFound();
            }
            ViewBag.MAT_ID = new SelectList(db.MATERIA, "MAT_ID", "MAT_NOMBRE", pLAN_MATERIA.MAT_ID);
            ViewBag.PLA_ID = new SelectList(db.PLAN, "PLA_ID", "PLA_NOMBRE", pLAN_MATERIA.PLA_ID);
            return View(pLAN_MATERIA);
        }

        // POST: PLAN_MATERIA/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PLM_ID,PLA_ID,MAT_ID")] PLAN_MATERIA pLAN_MATERIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pLAN_MATERIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MAT_ID = new SelectList(db.MATERIA, "MAT_ID", "MAT_NOMBRE", pLAN_MATERIA.MAT_ID);
            ViewBag.PLA_ID = new SelectList(db.PLAN, "PLA_ID", "PLA_NOMBRE", pLAN_MATERIA.PLA_ID);
            return View(pLAN_MATERIA);
        }

        // GET: PLAN_MATERIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PLAN_MATERIA pLAN_MATERIA = db.PLAN_MATERIA.Find(id);
            if (pLAN_MATERIA == null)
            {
                return HttpNotFound();
            }
            return View(pLAN_MATERIA);
        }

        // POST: PLAN_MATERIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PLAN_MATERIA pLAN_MATERIA = db.PLAN_MATERIA.Find(id);
            db.PLAN_MATERIA.Remove(pLAN_MATERIA);
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
