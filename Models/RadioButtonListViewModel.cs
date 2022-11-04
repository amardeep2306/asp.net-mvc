
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class RadioButtonListViewModel
    {
        
        [Display(Name = "Select the Flower")]
        public List<Flower> Flowers { get; set; }

        [Required]
        public string SelectedtFlower { get; set; }

        [Display(Name = "Image of the selected flower")]
        public string SelectedtImage { get; set; }
    }
}