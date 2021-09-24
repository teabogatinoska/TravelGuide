using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_TRAVEL_GUIDE.Models
{
    public class CityAttraction
    {
        public int Id { get; set; }

        public string Type { get; set; }

        [Display(Name = "Attraction")]
        public string AttractionName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
    }
}