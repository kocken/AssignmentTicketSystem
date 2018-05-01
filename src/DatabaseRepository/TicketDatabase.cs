using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using TicketSystem.DatabaseRepository.Model;

namespace TicketSystem.DatabaseRepository
{
    public class TicketDatabase : ITicketDatabase
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS; Database=TicketSystem; Trusted_Connection=true";

        public TicketEvent EventAdd(string name, string description)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Query("insert into TicketEvents(EventName, EventHtmlDescription) values(@Name, @Description)", new { Name = name, Description = description });
                var addedEventQuery = connection.Query<int>("SELECT IDENT_CURRENT ('TicketEvents') AS Current_Identity").First();
                return connection.Query<TicketEvent>("SELECT * FROM TicketEvents WHERE TicketEventID=@Id", new { Id = addedEventQuery }).First();
            }
        }

        public void EventDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Query<TicketEvent>("DELETE FROM TicketEvents WHERE TicketEventID=@Id", new { Id = id });
            }
        }

        public List<TicketEvent> EventsGet()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<TicketEvent>("SELECT * FROM TicketEvents").ToList();
            }
        }

        public Venue VenueAdd(Venue venue)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Query("insert into Venues([VenueName],[Address],[City],[Country]) values(@Name,@Address, @City, @Country)", new { Name = venue.VenueName, Address = venue.Address, City = venue.City, Country = venue.Country });
                var addedVenueQuery = connection.Query<int>("SELECT IDENT_CURRENT ('Venues') AS Current_Identity").First();
                return connection.Query<Venue>("SELECT * FROM Venues WHERE VenueID=@Id", new { Id = addedVenueQuery }).First();
            }
        }

        public void VenueDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                connection.Query<TicketEvent>("DELETE FROM Venues WHERE VenueID=@Id", new { Id = id });
            }
        }

        public List<Venue> VenuesFind(string query)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Venue>("SELECT * FROM Venues WHERE VenueName like '%"+query+ "%' OR Address like '%" + query + "%' OR City like '%" + query + "%' OR Country like '%" + query + "%'").ToList();
            }
        }
        
        public List<Venue> VenuesGet()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Venue>("SELECT * FROM Venues").ToList();
            }
        }

    }
}
