using System.Collections.Generic;
using System.Web.Http;
using asp.net_mvc.Models;

namespace asp.net_mvc.Controllers
{
    public class FlowerApiController : ApiController
    {
        
        // GET api/flowerapi
        public IEnumerable<Flower> Get()
        {
            RadioButtonListViewModel rblvm = new RadioButtonListViewModel();

            return rblvm.Flowers;
        }

        // GET api/flowerapi/5
        public Flower Get(int id)
        {
            RadioButtonListViewModel rblvm = new RadioButtonListViewModel();
            Flower item = rblvm.Flowers.Find(temp => temp.Id == id);

            return item;
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