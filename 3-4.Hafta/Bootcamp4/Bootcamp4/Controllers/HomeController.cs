using Bootcamp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootcamp4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Kullanicilar kullanicilar)
        {
            ViewBag.KullaniciAdi = kullanicilar.KullaniciAdi;
            return View();
        }


        public ActionResult CvOlustur()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CvOlustur(CvModel model)
        {
            ViewBag.AdSoyad = model.Adi + " " + model.Soyadi;
            ViewBag.Yas = model.Yasi;
            ViewBag.Telefon = model.Telefonu;
            ViewBag.Adres = model.Adres + " - " +model.Sehri;
            ViewBag.Bilgisayar = model.BilgisayarBilgisi;
            

            return View();
        }


        public ActionResult Kullanicilar()
        {
            List<Kullanicilar> model = new List<Kullanicilar>();

            Kullanicilar k = new Kullanicilar
            {
                KullaniciAdi = "YunusY",
                Adi = "Yunus Yaşar",
                Sifre = "yasar123",
                Telefon = "055555555"
            };

            model.Add(k);

            Kullanicilar kk = new Kullanicilar
            {
                KullaniciAdi = "BilalH",
                Adi = "Bilal Hamdo",
                Sifre = "bilal123",
                Telefon = "05443333"
            };

            model.Add(kk);


            Kullanicilar kkk = new Kullanicilar
            {
                KullaniciAdi = "BerfinK",
                Adi = "Berfin Kurtoğlu",
                Sifre = "berfin123",
                Telefon = "04454444"
            };

            model.Add(kkk);

            ViewBag.Data = model.ToList();

            return View(model.ToList());
        }
    }
}