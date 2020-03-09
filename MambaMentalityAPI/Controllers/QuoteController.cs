using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MambaMentalityAPI.Models;
using MambaMentalityAPI;
using Microsoft.AspNetCore.Mvc;


namespace MambaMentalityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        // GET api/quote
        [HttpGet]
        public ActionResult<IEnumerable<Quote>> Get()
        {
            using (var context = new QuoteDBContext())
            {
                return context.Quotes.ToList();
            }
        }

        // GET api/quote/id
        [HttpGet("{id}")]
        public ActionResult<Quote> Get(int id)
        {
            using (var context = new QuoteDBContext())
            {
                return context.Quotes.FirstOrDefault(q => q.Id == id);
            }
        }

        /*
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
