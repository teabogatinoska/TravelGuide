using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_TRAVEL_GUIDE.Models
{
    public class CityReview
    {
        public int Id { get; set; }

        [Range(1, 5)]
        [Required]
        public int Rating { get; set; }

        [Required]
        [StringLength(1024)]
        [Display(Name = "Review")]
        [DataType(DataType.MultilineText)]
        public string ReviewText { get; set; }
        public int CityId { get; set; }
    }
}