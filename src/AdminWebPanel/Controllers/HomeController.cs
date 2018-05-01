using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdminWebPanel.Models;
using TicketSystem.RestApiClient;
using TicketSystem.DatabaseRepository.Model;
using Microsoft.Extensions.Logging;

namespace AdminWebPanel.Controllers
{
    public class HomeController : Controller
    {   
        private TicketApi api = new TicketApi();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Venue()
        {
            return View();
        }

        public IActionResult Event()
        {
            return View();
        }

        public IActionResult VenueAdd(Venue venue)
        {
            if (ModelState.IsValid)
            {
                if (api.VenueAdd(venue))
                {
                    TempData["notice"] = "Venue was successfully added";
                    _logger.LogInformation("Venue {@Venue} was successfully added", venue);
                }
                else
                {
                    TempData["notice"] = "Venue was valid but failed to get added";
                    _logger.LogError("Venue {@Venue} was valid but failed to get added", venue);
                }
            }
            else
            {
                TempData["notice"] = "Venue failed to get added - form contained invalid values";
            }
            return RedirectToAction("Venue");
        }

        public IActionResult EventAdd(TicketEvent ticketEvent)
        {
            if (ModelState.IsValid)
            {
                if (api.EventAdd(ticketEvent))
                {
                    TempData["notice"] = "Event was successfully added";
                    _logger.LogInformation("Event {@ticketEvent} was successfully added", ticketEvent);
                }
                else
                {
                    TempData["notice"] = "Event was valid but failed to get added";
                    _logger.LogError("Event {@ticketEvent} was valid but failed to get added", ticketEvent);
                }
            }
            else
            {
                TempData["notice"] = "Event failed to get added - form contained invalid values";
            }
            return RedirectToAction("Event");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
