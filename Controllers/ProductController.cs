
using System.Collections.Generic;
using System.Web.Http;
using asp.net_mvc.Models;


namespace asp.net_mvc.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> productItems = new List<Product>
        {
            new Product() { ProductId = 101, ProductName = "Scooter", Image = "/images/scooter.png", Price = 45000 },
            new Product() { ProductId = 102, ProductName = "Ebike", Image = "/images/ebike.jpg", Price = 38000 },
            new Product() { ProductId = 103, ProductName = "Bike", Image = "/images/bike.jpg", Price = 94000 },
            new Product() { ProductId = 104, ProductName = "Car", Image = "/images/car.jpg", Price = 494000 }
        };

        // GET: api/product
        public List<Product> Get()
        {
            return productItems;
        }

        // GET: api/product/5
        public Product Get(int id)
        {
            Product item = productItems.Find(temp => temp.ProductId == id);
            return item;
        }

        // POST: api/product
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/product/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/product/5
        public void Delete(int id)
        {
        }
    }
}
