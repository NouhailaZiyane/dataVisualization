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
    public class c3Controller : Controller
    {
        private DataContext db = new DataContext();

        // GET: c3
        public ActionResult Index()
        {
            return View(db.c3.ToList());
        }

        // GET: c3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            c3 c3 = db.c3.Find(id);
            if (c3 == null)
            {
                return HttpNotFound();
            }
            return View(c3);
        }

        // GET: c3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: c3/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "up,us,men,equip,nbr,achat")] c3 c3)
        {
            if (ModelState.IsValid)
            {
                db.c3.Add(c3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c3);
        }

        // GET: c3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            c3 c3 = db.c3.Find(id);
            if (c3 == null)
            {
                return HttpNotFound();
            }
            return View(c3);
        }

        // POST: c3/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "up,us,men,equip,nbr,achat")] c3 c3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c3);
        }

        // GET: c3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            c3 c3 = db.c3.Find(id);
            if (c3 == null)
            {
                return HttpNotFound();
            }
            return View(c3);
        }

        // POST: c3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            c3 c3 = db.c3.Find(id);
            db.c3.Remove(c3);
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
