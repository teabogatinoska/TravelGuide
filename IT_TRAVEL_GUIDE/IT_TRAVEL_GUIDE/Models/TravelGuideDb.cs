using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IT_TRAVEL_GUIDE.Models
{
    public class TravelGuideDb : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<CityReview> Reviews { get; set; }
        public DbSet<CityAttraction> Attractions { get; set; }

    }
}