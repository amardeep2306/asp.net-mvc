using System;
using System.Collections.Generic;
using System.Web.Mvc;
using asp.net_mvc.Models;
using System.Linq;

namespace asp.net_mvc.Controllers
{
    public class TasksController : Controller
    {
        private FlowerDBContext db = new FlowerDBContext();
        private ProductDBContext productDB = new ProductDBContext();

        // GET: Task
        public ActionResult Index()
        {
            ViewBag.Title = "Change Button Color On MouseOver In Asp.Net";
            return View();
        }
         
        // GET: Task/AddSubInteger
        public ActionResult AddSubInteger()
        {
            ViewBag.Title = "Addition or Subtraction based on selection";
            return View();
        }

        [HttpPost]
        public ActionResult AddSubInteger(AddSubIntegerViewModel avm, string command)
        {
            ViewBag.Title = "Addition or Subtraction based on selection";
            if (ModelState.IsValid)
            {
                double num1 = Convert.ToDouble(avm.FirstNumber);
                double num2 = Convert.ToDouble(avm.SecondNumber);
                if (command == "Add")
                {
                    avm.Result = num1 + num2;
                }
                else
                {
                    avm.Result = num1 - num2;
                }

                return View(avm);
            }
            else
            {
                avm.Result = 0;
                return View(avm);
            }

        }

        // GET: Task/ListBox
        public ActionResult ListBox(ListBoxViewModel lbm)
        {
            ViewBag.Title = "Show image and price based on the item selection";
            var products = from p in productDB.Products
                          orderby p.ProductId
                          select p;
            var productList = products.ToList();

            lbm.Products = productList.ConvertAll(p =>
            {
                return new SelectListItem()
                {
                    Text = p.ProductName,
                    Value = p.ProductId.ToString(),
                    Selected = false
                };
            });

            return View(lbm);
        }

        // GET: Task/ListBox
        public ActionResult RadioButtonList(RadioButtonListViewModel rblvm)
        {
            ViewBag.Title = "Show image based on the radio button list item selection";

            var flowers = from f in db.Flowers
                          orderby f.Id
                          select f;

            rblvm.Flowers =  flowers.ToList();

            return View(rblvm);
        }

        // GET: Task/ShowUniqueNumbers
        public ActionResult ShowUniqueNumbers()
        {
            ViewBag.Title = "Show unique numbers from the given input";

            return View();
        }

        // POST: UserForm
        [HttpPost]
        public ActionResult ShowUniqueNumbers(UniqueNumbersViewModel unvm)
        {
            ViewBag.Title = "Show unique numbers from the given input";
            if (ModelState.IsValid)
            {
                string givenNumber = unvm.Number;
                
                string resultString = string.Empty;
                for (int i = 0; i < givenNumber.Length; i++)
                {
                    if (!resultString.Contains(givenNumber[i].ToString()))
                    {
                        resultString += givenNumber[i];
                    }
                }

                unvm.UniqueNumbers = resultString;
            }

            return View(unvm);
        }
    }
}