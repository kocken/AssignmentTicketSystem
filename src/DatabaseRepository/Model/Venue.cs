﻿using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DatabaseRepository.Model
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }

        public override string ToString()
        {
            return "ID: " + VenueId + ", Name: " + VenueName + ", Address: " + Address + ", City: " + City + ", Country: " + Country;
        }
    }

}
