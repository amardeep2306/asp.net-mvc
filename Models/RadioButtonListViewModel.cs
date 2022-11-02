
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class RadioButtonListViewModel
    {
        
        [Display(Name = "Select the Flower")]
        public List<Flower> Flowers
        {
            get
            {
                List<Flower> flowers = new List<Flower>()
                {
                    new Flower() { Id = 101, Name = "Rose", Image = "/images/rose.jpg"},
                    new Flower() { Id = 102, Name = "Lotus", Image = "/images/lotus.jpg"},
                    new Flower() { Id = 103, Name = "Marigold", Image = "/images/marigold.jpg"},
                    new Flower() { Id = 104, Name = "Sunflower", Image = "/images/sunflower.jpg"},
                    new Flower() { Id = 105, Name = "Lily", Image = "/images/lily.jpg"},
                };
                return flowers;
            }
        }
        [Required]
        public string SelectedtFlower { get; set; }

        [Display(Name = "Image of the selected flower")]
        public string SelectedtImage { get; set; }
    }
}