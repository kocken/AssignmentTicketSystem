using TicketSystem.DatabaseRepository.Model;
using System.Collections.Generic;

namespace TicketSystem.DatabaseRepository
{
    public interface ITicketDatabase
    {
        /// <summary>
        /// Add a new Event to the database
        /// </summary>
        /// <param name="name">Name of the event</param>
        /// <param name="description">A desription of the event, html markup of the event is allowed</param>
        /// <returns>An object representing the newly created TicketEvent</returns>
        TicketEvent EventAdd(string name, string description);

        /// <summary>
        /// Add a new venue to the database
        /// </summary>
        /// <param name="venue">The venue object, with VenueName, Address, City & Country values</param>
        /// <returns>An object representing the newly created Venue</returns>
        Venue VenueAdd(Venue venue);


        /// <summary>
        /// Find all venus matching the query
        /// </summary>
        /// <param name="query">A text which is user i looking for in the venues</param>
        /// <returns>A list of venus matching the query</returns>
        List<Venue> VenuesFind(string query);
    }
}
