using System;
using System.Collections.Generic;
using System.Web.Mvc;
using asp.net_mvc.Models;

namespace asp.net_mvc.Controllers
{
    public class TasksController : Controller
    {
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
            List<Product> products = new List<Product>()
            {
                new Product() { ProductId = 101, ProductName = "Scooter", Image = "/images/scooter.png", Price = 45000 },
                new Product() { ProductId = 102, ProductName = "Ebike", Image = "/images/ebike.jpg", Price = 38000 },
                new Product() { ProductId = 103, ProductName = "Bike", Image = "/images/bike.jpg", Price = 94000 },
                new Product() { ProductId = 104, ProductName = "Car", Image = "/images/car.jpg", Price = 494000 }
            };
            ViewBag.products = products;
            lbm.Products = products.ConvertAll(p =>
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
    }
}