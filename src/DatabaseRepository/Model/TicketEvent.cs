﻿using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DatabaseRepository.Model
{
    public class TicketEvent
    {
        public int TicketEventId { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventHtmlDescription { get; set; }

        public override string ToString()
        {
            return "ID: " + TicketEventId + ", Name: " + EventName + ", Description: " + EventHtmlDescription;
        }
    }
}
