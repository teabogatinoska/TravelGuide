using IT_TRAVEL_GUIDE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_TRAVEL_GUIDE.Controllers
{
    public class HomeController : Controller
    {
        TravelGuideDb _db = new TravelGuideDb();
        public ActionResult Index(string searchTerm = null)
        {
            //var model =
            //    _db.Cities
            //    .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
            //    .Where(r => searchTerm == null || r.CityName.StartsWith(searchTerm))
            //    .Take(10)
            //    .Select(r => new CityListViewModel
            //    {
            //        Id = r.Id,
            //        CityName = r.CityName,
            //        Country = r.Country,
            //        CountOfReviews = r.Reviews.Count()
            //    });

            //return View(model);
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

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Barcelona()
        {
            return View("Barcelona");
        }
        public ActionResult Copenhagen()
        {
            return View("Copenhagen");
        }
        public ActionResult Vienna()
        {
            return View("Vienna");
        }
        public ActionResult Valencia()
        {
            return View("Valencia");
        }
        public ActionResult Skopje()
        {
            return View("Skopje");
        }
        public ActionResult Ohrid()
        {
            return View("Ohrid");
        }

    }
}