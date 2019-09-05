using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcStok2.Models.Entity;

namespace mvcStok2.Controllers
{
    public class SatisController : Controller
    { 
        // GET: Satis
        MVCStokEntities2 db = new MVCStokEntities2();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(SATISLAR s)
        {
            db.SATISLAR.Add(s);
            db.SaveChanges();
            return View("Index");
        }
    }
}