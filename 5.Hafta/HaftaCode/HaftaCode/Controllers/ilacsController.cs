using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HaftaCode.Models.Tablolarim;
using HaftaCode.Models.Veritabanim;

namespace HaftaCode.Controllers
{
    public class ilacsController : Controller
    {
        private Yardimci db = new Yardimci();

        // GET: ilacs
        public ActionResult Index()
        {
            return View(db.ilaclar.ToList());
        }

        // GET: ilacs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ilac ilac = db.ilaclar.Find(id);
            if (ilac == null)
            {
                return HttpNotFound();
            }
            return View(ilac);
        }

        // GET: ilacs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ilacs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Barkod,ilacadi,SkTarihi")] ilac ilac)
        {
            if (ModelState.IsValid)
            {
                db.ilaclar.Add(ilac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ilac);
        }

        // GET: ilacs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ilac ilac = db.ilaclar.Find(id);
            if (ilac == null)
            {
                return HttpNotFound();
            }
            return View(ilac);
        }

        // POST: ilacs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Barkod,ilacadi,SkTarihi")] ilac ilac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ilac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ilac);
        }

        // GET: ilacs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ilac ilac = db.ilaclar.Find(id);
            if (ilac == null)
            {
                return HttpNotFound();
            }
            return View(ilac);
        }

        // POST: ilacs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ilac ilac = db.ilaclar.Find(id);
            db.ilaclar.Remove(ilac);
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
