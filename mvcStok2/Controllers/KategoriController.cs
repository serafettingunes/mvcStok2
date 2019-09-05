using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcStok2.Models.Entity;

namespace mvcStok2.Controllers
{
    public class KategoriController : Controller
    {
        MVCStokEntities2 db = new MVCStokEntities2();
        
        // GET: Kategori
        public ActionResult Index()
        {
            var degerler = db.KATEGORILER.ToList();
            return View(degerler);

        }
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(KATEGORILER p1)
        {
            if (!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
             db.KATEGORILER.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult SIL(int id)
        {
            var ktgr = db.KATEGORILER.Find(id);
            db.KATEGORILER.Remove(ktgr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.KATEGORILER.Find(id);
            return View("KategoriGetir",ktgr);
        }
        public ActionResult Guncelle(KATEGORILER p1)
        {
            var ktg = db.KATEGORILER.Find(p1.KATEGORIID);
            ktg.KATEGORIAD = p1.KATEGORIAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}