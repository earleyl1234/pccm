﻿using System;

namespace PCCM.Web.Domain.Models
{
    public class Rentals
    {
        public int RentalId { get; set; }
        public DateTime? RentalBeginDate { get; set; }
        public DateTime? RentalEndDate { get; set; }
        public bool WillDrink { get; set; }
        public bool WillDance { get; set; }
    }
}
