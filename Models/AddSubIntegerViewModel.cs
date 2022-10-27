
using System.ComponentModel.DataAnnotations;

namespace asp.net_mvc.Models
{
    public class AddSubIntegerViewModel
    {
        [Display(Name = "Enter First Number")]
        [Required(ErrorMessage = "*First Number is required.")]
        public double FirstNumber { get; set; }

        [Display(Name = "Enter Second Number")]
        [Required(ErrorMessage = "*Second Number is required.")]
        public double SecondNumber { get; set; }
        public double Result { get; set; }
    }
}