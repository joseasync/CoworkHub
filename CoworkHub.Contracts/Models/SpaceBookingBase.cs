﻿using System;

namespace CoworkHub.Contracts.Models
{
    public class SpaceBookingBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRequested { get; set; }
    }
}