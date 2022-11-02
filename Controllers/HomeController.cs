 
using System.Web.Mvc;

namespace asp.net_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Asp.net MVC Training Tasks";
            return View();
        }
    }
}