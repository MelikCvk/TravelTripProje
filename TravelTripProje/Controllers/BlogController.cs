using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        Context c=new Context();    
        BlogYorum bly=new BlogYorum();
        public ActionResult Index()
        {
            bly.Deger1 = c.Blogs.ToList();
            bly.Deger3 = c.Blogs.Take(3);
            bly.Deger2 = c.Yorumlars.OrderByDescending(x => x.ID).Take(5).ToList();
            return View(bly);
        }
        public ActionResult BlogDetay(int? id)
        {
            //var blog = c.Blogs.Where(x => x.ID == id).ToList();
            bly.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            bly.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            bly.Deger3 = c.Blogs.OrderByDescending(x => x.ID).ToList();
            ViewBag.BlogId = id;
            return View(bly);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yr)
        {
            c.Yorumlars.Add(yr);
            c.SaveChanges();
            return PartialView();
        }
    }
}