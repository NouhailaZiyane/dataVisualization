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
    public class menages1Controller : Controller
    {
        private DataContext db = new DataContext();

        // GET: menages1
        public ActionResult Index()
        {
            return View(db.menage.ToList());
        }

        // GET: menages1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menage menage = db.menage.Find(id);
            if (menage == null)
            {
                return HttpNotFound();
            }
            return View(menage);
        }

        // GET: menages1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: menages1/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "up,us,men,chefmen,epouse,cadet,adresse1,adresse2,flg,sexe,age,netude,activite,nbrind,nbrind15,nbrindactif,revenu,categrvenu")] menage menage)
        {
            if (ModelState.IsValid)
            {
                db.menage.Add(menage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menage);
        }

        // GET: menages1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menage menage = db.menage.Find(id);
            if (menage == null)
            {
                return HttpNotFound();
            }
            return View(menage);
        }

        // POST: menages1/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "up,us,men,chefmen,epouse,cadet,adresse1,adresse2,flg,sexe,age,netude,activite,nbrind,nbrind15,nbrindactif,revenu,categrvenu")] menage menage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menage);
        }

        // GET: menages1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            menage menage = db.menage.Find(id);
            if (menage == null)
            {
                return HttpNotFound();
            }
            return View(menage);
        }

        // POST: menages1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            menage menage = db.menage.Find(id);
            db.menage.Remove(menage);
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
