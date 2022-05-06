using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using googleCharts.Data;
using googleCharts.Models;

namespace googleCharts.Controllers
{
    public class dbfilesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: dbfiles
        public ActionResult Index()
        {
            return View(db.files.ToList());
        }

        // GET: dbfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbfiles dbfiles = db.files.Find(id);
            if (dbfiles == null)
            {
                return HttpNotFound();
            }
            return View(dbfiles);
        }

        // GET: dbfiles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dbfiles/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tid,tabid,datafile,date_envoi,flg,acteurtid")] dbfiles dbfiles)
        {
            if (ModelState.IsValid)
            {
                db.files.Add(dbfiles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dbfiles);
        }

        // GET: dbfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbfiles dbfiles = db.files.Find(id);
            if (dbfiles == null)
            {
                return HttpNotFound();
            }
            return View(dbfiles);
        }

        // POST: dbfiles/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tid,tabid,datafile,date_envoi,flg,acteurtid")] dbfiles dbfiles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dbfiles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dbfiles);
        }

        // GET: dbfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dbfiles dbfiles = db.files.Find(id);
            if (dbfiles == null)
            {
                return HttpNotFound();
            }
            return View(dbfiles);
        }

        // POST: dbfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dbfiles dbfiles = db.files.Find(id);
            db.files.Remove(dbfiles);
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
