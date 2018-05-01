using System.Collections.Generic;
using TicketSystem.DatabaseRepository.Model;
using TicketSystem.RestApiClient.Model;

namespace TicketSystem.RestApiClient
{
    public interface ITicketApi
    {
        /// <summary>
        /// Get all tickets in the system 
        /// </summary>
        /// <returns></returns>
        //List<Ticket> TicketGet();

        /// <summary>
        /// Get a ticket by ID from the system Returns a single ticket
        /// </summary>
        /// <param name="ticketId">ID of the ticket</param>
        /// <returns></returns>
        //Ticket TicketTicketIdGet(int ticketId);

        /// <summary>
        /// Get all ticket-events in the system 
        /// </summary>
        /// <returns>Returns all events in a list</returns>
        List<TicketEvent> EventGet();

        /// <summary>
        /// Adds a ticket-event to the database
        /// </summary>
        /// <param name="ticketEvent">The TicketEvent object to add into the database</param>
        /// <returns></returns>
        bool EventAdd(TicketEvent ticketEvent);

        /// <summary>
        /// Get all venues in the system 
        /// </summary>
        /// <returns>Returns all venues in a list</returns>
        List<Venue> VenueGet();

        /// <summary>
        /// Adds a venue to the database
        /// </summary>
        /// <param name="venue">The Venue object to add into the database</param>
        /// <returns></returns>
        bool VenueAdd(Venue venue);
    }
}
