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
    public class grappesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: grappes
        public ActionResult Index()
        {
            return View(db.grappe.ToList());
        }

        // GET: grappes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            grappe grappe = db.grappe.Find(id);
            if (grappe == null)
            {
                return HttpNotFound();
            }
            return View(grappe);
        }

        // GET: grappes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: grappes/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "up,us,dc,se,nbrmen,remq,cgid")] grappe grappe)
        {
            if (ModelState.IsValid)
            {
                db.grappe.Add(grappe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grappe);
        }

        // GET: grappes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            grappe grappe = db.grappe.Find(id);
            if (grappe == null)
            {
                return HttpNotFound();
            }
            return View(grappe);
        }

        // POST: grappes/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "up,us,dc,se,nbrmen,remq,cgid")] grappe grappe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grappe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grappe);
        }

        // GET: grappes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            grappe grappe = db.grappe.Find(id);
            if (grappe == null)
            {
                return HttpNotFound();
            }
            return View(grappe);
        }

        // POST: grappes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            grappe grappe = db.grappe.Find(id);
            db.grappe.Remove(grappe);
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
