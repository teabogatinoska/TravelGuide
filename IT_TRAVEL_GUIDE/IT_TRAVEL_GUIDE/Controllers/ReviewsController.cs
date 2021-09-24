using IT_TRAVEL_GUIDE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_TRAVEL_GUIDE.Controllers
{
    public class ReviewsController : Controller
    {
        TravelGuideDb _db = new TravelGuideDb();

        // GET: Reviews
        public ActionResult Index([Bind(Prefix="id")] int cityId)
        {
            var city = _db.Cities.Find(cityId);
            if (city != null)
            {
                return View(city);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int cityId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CityReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.CityId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CityReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.CityId });
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

    }
}
