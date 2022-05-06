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
    public class tablettesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: tablettes
        public ActionResult Index()
        {
            return View(db.tablette.ToList());
        }

        // GET: tablettes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablette tablette = db.tablette.Find(id);
            if (tablette == null)
            {
                return HttpNotFound();
            }
            return View(tablette);
        }

        // GET: tablettes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tablettes/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tabid,deviceid,modele,profilid")] tablette tablette)
        {
            if (ModelState.IsValid)
            {
                db.tablette.Add(tablette);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tablette);
        }

        // GET: tablettes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablette tablette = db.tablette.Find(id);
            if (tablette == null)
            {
                return HttpNotFound();
            }
            return View(tablette);
        }

        // POST: tablettes/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tabid,deviceid,modele,profilid")] tablette tablette)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tablette).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tablette);
        }

        // GET: tablettes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablette tablette = db.tablette.Find(id);
            if (tablette == null)
            {
                return HttpNotFound();
            }
            return View(tablette);
        }

        // POST: tablettes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tablette tablette = db.tablette.Find(id);
            db.tablette.Remove(tablette);
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
