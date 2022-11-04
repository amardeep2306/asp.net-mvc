
using System.Collections.Generic;
using System.Web.Http;
using asp.net_mvc.Models;
using System.Linq;

namespace asp.net_mvc.Controllers
{
    public class ProductController : ApiController
    {
        private ProductDBContext db = new ProductDBContext();

        // GET: api/product
        public List<Product> Get()
        {
            var products = from p in db.Products
                           orderby p.ProductId
                           select p;

            return products.ToList();
        }

        // GET: api/product/5
        public Product Get(int id)
        {
            var products = from p in db.Products
                           orderby p.ProductId
                           where p.ProductId == id
                           select p;

            return products.SingleOrDefault();
        }
    }
}
