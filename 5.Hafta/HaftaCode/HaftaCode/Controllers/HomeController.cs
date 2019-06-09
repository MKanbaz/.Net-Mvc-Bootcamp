using HaftaCode.Models.Tablolarim;
using HaftaCode.Models.Veritabanim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaftaCode.Controllers
{
    public class HomeController : Controller
    {
        Yardimci db = new Yardimci();
        public ActionResult Index()
        {
            var listele = db.ilaclar.ToList();

            ViewBag.Listemiz = listele;
            return View(listele);
        }


        public ActionResult Ekle()
        {
            List<Firma> firma = db.Firmalar.ToList();
            ViewBag.FirmalariListele = new SelectList(firma, "ID", "FirmaAdi");
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(ilac ilc)
        {
            db.ilaclar.Add(ilc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Duzenle(int id)
        {
            var bul = db.ilaclar.FirstOrDefault(x => x.Barkod == id);
            return View(bul);
        }

        [HttpPost]
        public ActionResult Duzenle(ilac ilc)
        {
            var bul = db.ilaclar.FirstOrDefault(x => x.Barkod == ilc.Barkod);
            bul.ilacadi = ilc.ilacadi;
            bul.SkTarihi = ilc.SkTarihi;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var bul = db.ilaclar.FirstOrDefault(x => x.Barkod == id);
            db.ilaclar.Remove(bul);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}