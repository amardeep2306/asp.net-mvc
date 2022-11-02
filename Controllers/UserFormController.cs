
using System.Web.Mvc;
using asp.net_mvc.Models;


namespace asp.net_mvc.Controllers
{
    public class UserFormController : Controller
    {
        // GET: UserForm
        public ActionResult Index()
        {
            ViewBag.Title = "User Registration Form Validation";
            UserFormViewModel ufvm = new UserFormViewModel();

            return View(ufvm);
        }

        // POST: UserForm
        [HttpPost]
        public ActionResult Index(UserFormViewModel ufvm)
        {
            ViewBag.Title = "User Registration Form Validation";
            if (ModelState.IsValid)
            {
                
                string username = ufvm.Username;
                Response.Cookies["username"].Value = username;

                return RedirectToAction("Welcome");
            }

            return View(ufvm);
        }

        // GET: UserForm/Welcome
        public ActionResult Welcome()
        {
            ViewBag.Title = "Showing cookie value";

            return View();
        }
    }
}