﻿using System;

namespace PCCM.Web.Domain.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventAddress { get; set; }

        public string EventShortDescription
            => EventDescription.Length > 225
                ? $"{EventDescription.Substring(0, 225)}"
                : $"{EventDescription}";

        public DateTime? EventDate { get; set; }
        public string EventDayOfWeek => EventDate.Value.ToString("dddd");
        public double TicketPrice { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
