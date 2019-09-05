using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcStok2.Models.Entity;

namespace mvcStok2.Controllers
{
    public class MusteriController : Controller
    {
        MVCStokEntities2 db = new MVCStokEntities2();
        // GET: Musteri
        public ActionResult Index(string p)
        {
            var degerler = from d in db.MUSTERILER.ToList()select d;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(m => m.MUSTERIAD.Contains(p));
            }
            return View(degerler.ToList());

            // var degerler = db.MUSTERILER.ToList();
            //return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteriEkle(MUSTERILER id)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteriEkle");
            }
            db.MUSTERILER.Add(id);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var musteri = db.MUSTERILER.Find(id);
            db.MUSTERILER.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var musteri = db.MUSTERILER.Find(id);
            return View("MusteriGetir",musteri);
        }
        public ActionResult MusteriGuncelle(MUSTERILER p1)
        {
            var musteri = db.MUSTERILER.Find(p1.MUSTERIID);
            musteri.MUSTERIAD = p1.MUSTERIAD;
            musteri.MUSTERISOYAD = p1.MUSTERISOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}