using System;

namespace OfficeBooker.Models
{
    public class SpaceBookingRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateRequested { get; set; }
    }
}