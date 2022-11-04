using System.Collections.Generic;
using System.Web.Http;
using asp.net_mvc.Models;
using System.Linq;

namespace asp.net_mvc.Controllers
{
    public class FlowerApiController : ApiController
    {
        private FlowerDBContext db = new FlowerDBContext();

        // GET api/flowerapi
        public IEnumerable<Flower> Get()
        {
            var flowers = from f in db.Flowers
                           orderby f.Id
                           select f;

            return flowers.ToList();
        }

        // GET api/flowerapi/5
        public Flower Get(int id)
        {
            var flowers = from f in db.Flowers
                           orderby f.Id
                           where f.Id == id
                           select f;

            return flowers.SingleOrDefault();
        }

        // POST api/flowerapi
        public void Post([FromBody] string value)
        {
        }

        // PUT api/flowerapi/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/flowerapi/5
        public void Delete(int id)
        {
        }
    }
}