using MetinBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetinBot.Controllers
{
    public class HomeController : Controller
    {
        Yardimcim db = new Yardimcim();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Kullanici()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kullanici(string kadi)
        {
            Session["Adi"] = kadi;
            return RedirectToAction("Metin");
        }

        public ActionResult Metin()
        {
            return View();
        } 


        [HttpPost]
        public JsonResult Sorgu(string soru)
        {
            if (soru.ToLower() == "kimim")
            {
                string kimsinincevabi = Session["Adi"].ToString();
                return Json(kimsinincevabi);
            }
            else
            {
                var bul = db.Sorular.FirstOrDefault(x => x.Soru.ToLower() == soru);
                if (bul == null)
                {
                    return Json("Boş");
                }
                else
                {
                    return Json(bul.Cevap);
                }
            }
            
        }
    }
}