using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminWebPanel.Models;
using TicketSystem.RestApiClient;
using TicketSystem.DatabaseRepository.Model;

namespace AdminWebPanel.Controllers
{
    public class HomeController : Controller
    {   
        private TicketApi api = new TicketApi();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VenueAdd(Venue venue)
        {
            api.VenueAdd(venue);
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
