using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using TicketSystem.DatabaseRepository.Model;
using TicketSystem.RestApiClient.Model;

namespace TicketSystem.RestApiClient
{
    public class TicketApi : ITicketApi
    {
        // Implemented using RestSharp: http://restsharp.org/

        private string apiLink = "http://localhost:59914/api/";

        //public List<Ticket> TicketGet()
        //{
        //    var client = new RestClient(apiLink);
        //    var request = new RestRequest("ticket", Method.GET);
        //    var response = client.Execute<List<Ticket>>(request);
        //    return response.Data;
        //}

        //public Ticket TicketTicketIdGet(int ticketId)
        //{
        //    var client = new RestClient(apiLink);
        //    var request = new RestRequest("ticket/{id}", Method.GET);
        //    request.AddUrlSegment("id", ticketId);
        //    var response = client.Execute<Ticket>(request);

        //    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        //    {
        //        throw new KeyNotFoundException(string.Format("Ticket with ID: {0} is not found", ticketId));
        //    }

        //    return response.Data;
        //}

        public List<TicketEvent> EventGet()
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest("event", Method.GET);
            var response = client.Execute<List<TicketEvent>>(request);
            return response.Data;
        }

        public bool EventAdd(TicketEvent ticketEvent)
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest("event", Method.POST);
            var value = JsonConvert.SerializeObject(ticketEvent);
            request.AddParameter("application/json", value, ParameterType.RequestBody);
            var response = client.Execute<Venue>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }

        public List<Venue> VenueGet()
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest("venue", Method.GET);
            var response = client.Execute<List<Venue>>(request);
            return response.Data;
        }

        public bool VenueAdd(Venue venue)
        {
            var client = new RestClient(apiLink);
            var request = new RestRequest("venue", Method.POST);
            var value = JsonConvert.SerializeObject(venue);
            request.AddParameter("application/json", value, ParameterType.RequestBody);
            var response = client.Execute<Venue>(request);
            return response.StatusCode == HttpStatusCode.OK;
        }
    }
}
