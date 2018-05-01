using TicketSystem.DatabaseRepository.Model;
using System.Collections.Generic;

namespace TicketSystem.DatabaseRepository
{
    public interface ITicketDatabase
    {
        /// <summary>
        /// Adds a new event to the database
        /// </summary>
        /// <param name="name">Name of the event</param>
        /// <param name="description">A desription of the event, html markup of the event is allowed</param>
        /// <returns>An object representing the newly created TicketEvent</returns>
        TicketEvent EventAdd(string name, string description);

        /// <summary>
        /// Deletes an event from the database
        /// </summary>
        /// <param name="id">Id of the event to delete</param>
        void EventDelete(int id);

        /// <summary>
        /// Gets all events from the database
        /// </summary>
        /// <returns>A list of all events</returns>
        List<TicketEvent> EventsGet();

        /// <summary>
        /// Add a new venue to the database
        /// </summary>
        /// <param name="venue">The venue object, with VenueName, Address, City & Country values</param>
        /// <returns>An object representing the newly created Venue</returns>
        Venue VenueAdd(Venue venue);

        /// <summary>
        /// Deletes a venue from the database
        /// </summary>
        /// <param name="id">Id of the venue to delete</param>
        void VenueDelete(int id);

        /// <summary>
        /// Find all venues matching the query
        /// </summary>
        /// <param name="query">A text which the user is looking for in the venues</param>
        /// <returns>A list of venues matching the query</returns>
        List<Venue> VenuesFind(string query);

        /// <summary>
        /// Gets all venues from the database
        /// </summary>
        /// <returns>A list of all venues</returns>
        List<Venue> VenuesGet();
    }
}
