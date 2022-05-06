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
    public class progsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: progs
        public ActionResult Index()
        {
            return View(db.prog.ToList());
        }

        // GET: progs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prog prog = db.prog.Find(id);
            if (prog == null)
            {
                return HttpNotFound();
            }
            return View(prog);
        }

        // GET: progs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: progs/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "up,us,psg,annee,mois,tabid,flag")] prog prog)
        {
            if (ModelState.IsValid)
            {
                db.prog.Add(prog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(prog);
        }

        // GET: progs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prog prog = db.prog.Find(id);
            if (prog == null)
            {
                return HttpNotFound();
            }
            return View(prog);
        }

        // POST: progs/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "up,us,psg,annee,mois,tabid,flag")] prog prog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prog);
        }

        // GET: progs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prog prog = db.prog.Find(id);
            if (prog == null)
            {
                return HttpNotFound();
            }
            return View(prog);
        }

        // POST: progs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            prog prog = db.prog.Find(id);
            db.prog.Remove(prog);
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
