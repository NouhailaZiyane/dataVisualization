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
    public class cgeosController : Controller
    {
        private DataContext db = new DataContext();

        // GET: cgeos
        public ActionResult Index()
        {
            return View(db.cgeo.ToList());
        }

        // GET: cgeos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cgeo cgeo = db.cgeo.Find(id);
            if (cgeo == null)
            {
                return HttpNotFound();
            }
            return View(cgeo);
        }

        // GET: cgeos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: cgeos/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tid,code,lib,libar,niveau,pid")] cgeo cgeo)
        {
            if (ModelState.IsValid)
            {
                db.cgeo.Add(cgeo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cgeo);
        }

        // GET: cgeos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cgeo cgeo = db.cgeo.Find(id);
            if (cgeo == null)
            {
                return HttpNotFound();
            }
            return View(cgeo);
        }

        // POST: cgeos/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tid,code,lib,libar,niveau,pid")] cgeo cgeo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cgeo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cgeo);
        }

        // GET: cgeos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cgeo cgeo = db.cgeo.Find(id);
            if (cgeo == null)
            {
                return HttpNotFound();
            }
            return View(cgeo);
        }

        // POST: cgeos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cgeo cgeo = db.cgeo.Find(id);
            db.cgeo.Remove(cgeo);
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
