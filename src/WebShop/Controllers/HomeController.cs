﻿using System;
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
            VenueListModel model = new VenueListModel();
            model.Venues = api.VenueGet();
            return View(model);
        }

        public IActionResult Events()
        {
            EventListModel model = new EventListModel();
            model.Events = api.EventGet();
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
