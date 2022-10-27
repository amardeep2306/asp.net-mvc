
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class ListBoxViewModel
    {
        [Display(Name = "Select the Product")]
        public IEnumerable<SelectListItem> Products { get; set; }
          
        [Display(Name = "Price of the selected product")]
        public double SelectedProductPrice { get; set; }

        [Display(Name = "Image of the selected product")]
        public string SelectedProductImage { get; set; }
    }
}