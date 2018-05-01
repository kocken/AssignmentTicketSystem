using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.DatabaseRepository;
using TicketSystem.DatabaseRepository.Model;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class VenueController : Controller
    {
        TicketDatabase db = new TicketDatabase();

        // GET api/venue
        [HttpGet]
        public IEnumerable<Venue> Get()
        {
            return db.VenuesGet();
        }

        // GET api/venue/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/venue
        [HttpPost]
        public void Post([FromBody]Venue venue)
        {
            if (ModelState.IsValid)
            {
                db.VenueAdd(venue);
            }
        }

        // PUT api/venue/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/venue/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.VenueDelete(id);
        }
    }
}
