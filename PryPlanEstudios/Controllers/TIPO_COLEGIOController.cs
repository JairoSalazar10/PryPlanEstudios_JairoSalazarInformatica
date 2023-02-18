﻿using System;
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
    public class TIPO_COLEGIOController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TIPO_COLEGIO
        public ActionResult Index()
        {
            return View(db.TIPO_COLEGIO.ToList());
        }

        // GET: TIPO_COLEGIO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_COLEGIO tIPO_COLEGIO = db.TIPO_COLEGIO.Find(id);
            if (tIPO_COLEGIO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_COLEGIO);
        }

        // GET: TIPO_COLEGIO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_COLEGIO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TPC_ID,TPC_NOMBRE")] TIPO_COLEGIO tIPO_COLEGIO)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_COLEGIO.Add(tIPO_COLEGIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_COLEGIO);
        }

        // GET: TIPO_COLEGIO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_COLEGIO tIPO_COLEGIO = db.TIPO_COLEGIO.Find(id);
            if (tIPO_COLEGIO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_COLEGIO);
        }

        // POST: TIPO_COLEGIO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TPC_ID,TPC_NOMBRE")] TIPO_COLEGIO tIPO_COLEGIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_COLEGIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_COLEGIO);
        }

        // GET: TIPO_COLEGIO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_COLEGIO tIPO_COLEGIO = db.TIPO_COLEGIO.Find(id);
            if (tIPO_COLEGIO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_COLEGIO);
        }

        // POST: TIPO_COLEGIO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_COLEGIO tIPO_COLEGIO = db.TIPO_COLEGIO.Find(id);
            db.TIPO_COLEGIO.Remove(tIPO_COLEGIO);
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
