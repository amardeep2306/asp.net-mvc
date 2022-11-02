using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class UserFormViewModel
    {
        [Required]
        [Display(Name = "Username")]
        [RegularExpression(@"^(?=.{6,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username should contain 6-20 characters")]
        [StringLength(15)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2090")]
        [Display(Name = "Date")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string SelectedCountry { get; set; }

        public IEnumerable<SelectListItem> Countries {
            get
            {
                List<SelectListItem> countryList = new List<SelectListItem>();
                countryList.Add(new SelectListItem { Text = "India", Value = "India" });
                countryList.Add(new SelectListItem { Text = "USA", Value = "USA" });
                countryList.Add(new SelectListItem { Text = "Russia", Value = "Russia" });
                countryList.Add(new SelectListItem { Text = "Nepal", Value = "Nepal" });
                countryList.Add(new SelectListItem { Text = "UK", Value = "UK" });
                return countryList;
            }
        }
    }
}