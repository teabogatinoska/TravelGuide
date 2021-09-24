using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_TRAVEL_GUIDE.Models
{
    public class CityListViewModel
    {
        public int Id { get; set; }

        [Display(Name = "City")]
        public string CityName { get; set; }
        public string Country { get; set; }
        public int CountOfReviews { get; set; }
    }
}