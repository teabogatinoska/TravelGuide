using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_TRAVEL_GUIDE.Models
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        public string CityName { get; set; }
        public string Country { get; set; }
        public virtual ICollection<CityReview> Reviews { get; set; }
        public virtual ICollection<CityAttraction> Attractions { get; set; }
    }
}