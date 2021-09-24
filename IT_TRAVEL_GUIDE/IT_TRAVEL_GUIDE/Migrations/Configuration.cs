namespace IT_TRAVEL_GUIDE.Migrations
{
    using IT_TRAVEL_GUIDE.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IT_TRAVEL_GUIDE.Models.TravelGuideDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IT_TRAVEL_GUIDE.Models.TravelGuideDb";
        }

        protected override void Seed(IT_TRAVEL_GUIDE.Models.TravelGuideDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Cities.AddOrUpdate(r => r.CityName,
                new City { CityName = "Skopje", Country = "Macedonia" },
                new City { CityName = "Ohrid", Country = "Macedonia" },
                new City
                {
                    CityName = "Copenhagen",
                    Country = "Denmark",
                    Reviews =
                        new List<CityReview>
                        {
                            new CityReview { Rating = 4, ReviewText = "Great City!" }
                        }
                });
        }
    }
}
