using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class UniqueNumbersViewModel
    {
        [Required]
        [Display(Name = "Enter Number")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Given input must be numeric")]
        public string Number { get; set; }

        [Display(Name = "Unique Numbers")]
        public string UniqueNumbers { get; set; }
    }
}