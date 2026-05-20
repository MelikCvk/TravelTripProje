using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(6).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Destinations()
        {
            return View();
        }
        public PartialViewResult partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial3()
        {
            var degr = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(degr);
        }
        public PartialViewResult partial4()
        {
            var dgr = c.Blogs.Take(3).ToList();
            return PartialView(dgr);
        }
        public PartialViewResult partial5()
        {
            var dg = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(dg);
        }
    }
}