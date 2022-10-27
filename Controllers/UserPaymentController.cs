
using System.Web.Mvc;
using asp.net_mvc.Models;

namespace asp.net_mvc.Controllers
{
    public class UserPaymentController : Controller
    {
        // GET: UserPayment
        public ActionResult Index()
        {
            ViewBag.Title = "User Payment Form Validation";
            PaymentViewModel pvm = new PaymentViewModel();

            return View(pvm);
        }

        // POST: UserPayment
        [HttpPost]
        public ActionResult Index(PaymentViewModel pvm)
        {
            ViewBag.Title = "User Payment Form Validation";
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Success";
                return View("Success");
            }

            return View(pvm);
        }
    }
}