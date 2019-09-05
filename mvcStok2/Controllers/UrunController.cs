using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcStok2.Models.Entity;
using PagedList;
using PagedList.Mvc;
namespace mvcStok2.Controllers
{
    public class UrunController : Controller
    {
        MVCStokEntities2 db = new MVCStokEntities2();
        // GET: Urun
        public ActionResult Index(int sayfa=1)
        {

            //var degerler = db.URUNLER.ToList();
            var degerler = db.URUNLER.ToList().ToPagedList(sayfa,4);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Urun()
        {
            List<SelectListItem> degerler = (from i in db.KATEGORILER.ToList()

                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;


            return View();
        }
        [HttpPost]
        public ActionResult Urun(URUNLER u1)
        {
            var ktgr = db.KATEGORILER.Where(m => m.KATEGORIID == u1.KATEGORILER.KATEGORIID).FirstOrDefault();
            u1.KATEGORILER = ktgr;
            db.URUNLER.Add(u1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult SIL(int id)
        {
            var urun = db.URUNLER.Find(id);
            db.URUNLER.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var ktgr = db.URUNLER.Find(id);
            List<SelectListItem> degerler = (from i in db.KATEGORILER.ToList()

                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;

            return View("UrunGetir", ktgr);
        }
        public ActionResult URUNGUNCELLE(URUNLER p)
        {
            
           


            var urun = db.URUNLER.Find(p.URUNID);
            
            urun.URUNAD = p.URUNAD;
            urun.MARKA = p.MARKA;
            urun.FIYAT = p.FIYAT;
            //urun.KATEGORI = p.KATEGORI;
            urun.STOK = p.STOK;
            //var ktgr = db.KATEGORILER.Where(m => m.KATEGORIID == p.KATEGORILER.KATEGORIID).FirstOrDefault();
            //urun.KATEGORI = ktgr.KATEGORIID;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}