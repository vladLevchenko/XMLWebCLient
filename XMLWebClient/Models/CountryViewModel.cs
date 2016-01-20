using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XMLWebClient.Models
{
    public class CountryViewModel
    {
        [Required(ErrorMessage ="Country name is required")]
        public string Name {get;set;}

        [Required(ErrorMessage = "Capital name is required")]
        public string Capital { get; set; }

        [Required(ErrorMessage = "Population number is required")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage ="Population should be integer number")]
        public int Population { get; set; }
    }
}