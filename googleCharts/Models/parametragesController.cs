using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using googleCharts.Data;

namespace googleCharts.Models
{
    public class parametragesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: parametrages
        public ActionResult Index()
        {
            return View(db.parametrage.ToList());
        }

        // GET: parametrages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrage parametrage = db.parametrage.Find(id);
            if (parametrage == null)
            {
                return HttpNotFound();
            }
            return View(parametrage);
        }

        // GET: parametrages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: parametrages/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "paramid,param,decsription,valeur")] parametrage parametrage)
        {
            if (ModelState.IsValid)
            {
                db.parametrage.Add(parametrage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametrage);
        }

        // GET: parametrages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrage parametrage = db.parametrage.Find(id);
            if (parametrage == null)
            {
                return HttpNotFound();
            }
            return View(parametrage);
        }

        // POST: parametrages/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "paramid,param,decsription,valeur")] parametrage parametrage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametrage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametrage);
        }

        // GET: parametrages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            parametrage parametrage = db.parametrage.Find(id);
            if (parametrage == null)
            {
                return HttpNotFound();
            }
            return View(parametrage);
        }

        // POST: parametrages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            parametrage parametrage = db.parametrage.Find(id);
            db.parametrage.Remove(parametrage);
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
