using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.Hafta.Controllers
{
    public class AnaController : Controller
    {
        // GET: Ana
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult VieweVeriGonderme()
        {
            string viewbag = "ViewBag ile veri gönderme";
            string viewdata = "ViewData ile veri gönderme";
            string tempdata = "TempData ile veri gönderme";

            ViewBag.Viewbagornek = viewbag;
            ViewData["Viewdataornek"] = viewdata;
            TempData["Tempdataornek"] = tempdata;
            return View();
        }


        public ActionResult HtmlHelperKullanimi()
        {
            return View();
        }


        public ActionResult ViewdenControlleraVeriGonderme()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewdenControlleraVeriGonderme(string kullaniciadi, string sifre, string cinsiyet, bool? sozlesme, string adres, string Sehir)
        {
            ViewBag.Kullanici = kullaniciadi;
            if (sozlesme == true)
            {
                
            }
            else
            {
                ViewBag.Durum = "Sözleşme Kabul edilmedi";
            }
            return View();
        }
    }
}