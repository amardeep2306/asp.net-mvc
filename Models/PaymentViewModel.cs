using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using ExpressiveAnnotations.Attributes;

namespace asp.net_mvc.Models
{
    public enum PaymentMode
    {
        Cash,
        Credit    
    }

    public class PaymentViewModel
    {
        [Display(Name = "Username")]
        [RegularExpression(@"^(?=.{6,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$", ErrorMessage = "Username should contain 6-20 characters")]
        [Required]
        public string Username { get; set; }

        [Display(Name = "Select the Payment Mode")]
        [Required(ErrorMessage = "Please select the required Payment Mode")]
        public PaymentMode SelectedPaymentMode { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Amount is not in the expected format")]
        [Required(ErrorMessage = "Please enter the Amount")]
        public double Amount { get; set; }

        [Display(Name = "Card Number")]
        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please enter the Card Number")]
        [CreditCard(ErrorMessage = "Invalid Credit Card")]
        public string CreditCardNumber { get; set; }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please enter the CVV")]
        [Display(Name = "CVV")]
        [RegularExpression(@"^[0-9]{3,4}$", ErrorMessage = "CVV is not in the expected format")]
        public string CVV { get; set; }

        public IEnumerable<SelectListItem> Months
        {
            get
            {
                List<SelectListItem>  monthList = new List<SelectListItem>();
                for (int i = 1; i <= 12; i++)
                {
                    DateTime month = new DateTime(2000, i, 1);
                    monthList.Add(new SelectListItem { Text = month.ToString("MM"), Value = month.ToString("MM") });
                }
                return monthList;
            }
        }

        public IEnumerable<SelectListItem> Years
        {
            get
            {
                List<SelectListItem> yearList = new List<SelectListItem>();
                for (int i = 0; i <= 11; i++)
                {
                    String year = (DateTime.Today.Year + i).ToString();
                    yearList.Add(new SelectListItem { Text = year, Value = year });
                }
                return yearList;
            }
        }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please select the month of expiry")]
        public string SelectedMonth { get; set; }

        [RequiredIf("SelectedPaymentMode == PaymentMode.Credit", ErrorMessage = "Please select the year of expiry")]
        public string SelectedYear { get; set; }
    }
}