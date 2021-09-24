using IT_TRAVEL_GUIDE.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_TRAVEL_GUIDE.Controllers
{
    public class AttractionsController : Controller
    {
        TravelGuideDb _db = new TravelGuideDb();

        // GET: Attractions
        public ActionResult Index([Bind(Prefix = "id")] int cityId)
        {
            var city = _db.Cities.Find(cityId);
            if (city != null)
            {
                return View(city);
            }
            return HttpNotFound();
        }

        // GET: Attractions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attractions/Create
        [HttpPost]
        public ActionResult Create(CityAttraction attraction)
        {
            if (ModelState.IsValid)
            {
                _db.Attractions.Add(attraction);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = attraction.CityId });
            }
            return View(attraction);
        }

        // GET: Attractions/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _db.Attractions.Find(id);
            return View(model);
        }

        // POST: Attractions/Edit/5
        [HttpPost]
        public ActionResult Edit(CityAttraction attraction)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(attraction).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = attraction.CityId });
            }
            return View(attraction);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
