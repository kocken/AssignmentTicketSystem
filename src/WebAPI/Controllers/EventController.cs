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
    public class EventController : Controller
    {
        TicketDatabase db = new TicketDatabase();

        // GET api/event
        [HttpGet]
        public IEnumerable<TicketEvent> Get()
        {
            return db.EventsGet();
        }

        // GET api/event/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/event
        [HttpPost]
        public void Post([FromBody]TicketEvent ticketEvent)
        {
            if (ModelState.IsValid)
            {
                db.EventAdd(ticketEvent);
            }
        }

        // PUT api/event/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/event/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.EventDelete(id);
        }
    }
}
