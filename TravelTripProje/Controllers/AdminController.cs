
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blg = c.Blogs.Find(id);
            c.Blogs.Remove(blg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogDuzenle(int id)
        {
            var bl = c.Blogs.Find(id);
            return View(bl);
        }
        public ActionResult BlogGetir(int id)
        {
            var blgtir = c.Blogs.Find(id);
            return View("BlogGetir", blgtir);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var bgn = c.Blogs.Find(b.ID);
            bgn.Aciklama = b.Aciklama;
            bgn.Baslik = b.Baslik;
            bgn.BlogImage = b.BlogImage;
            bgn.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var yrm = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(yrm);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yrmgetir = c.Yorumlars.Find(id);
            return View("YorumGetir", yrmgetir);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrmguncelle = c.Yorumlars.Find(y.ID);
            yrmguncelle.KullaniciAdi = y.KullaniciAdi;
            yrmguncelle.Mail = y.Mail;
            yrmguncelle.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult Iletisim()
        {
            var liste = c.Iletisimler.ToList();
            return View(liste);
        }
    }
}