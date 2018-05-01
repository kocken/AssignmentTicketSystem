using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketSystem.DatabaseRepository.Model;
using TicketSystem.RestApiClient;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        private TicketApi api = new TicketApi();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Venues()
        {
            List<Venue> venues = api.VenueGet();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
