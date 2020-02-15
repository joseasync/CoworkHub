using OfficeBooker.BusinessRules.Models;
using System;

namespace OfficeBooker.BusinessRules
{
    public class SpaceBookingRequestExecution
    {
        public SpaceBookingRequestExecution()
        {
        }

        public SpaceBookingResult BookSpace(SpaceBookingRequest userRequest)
        {
            return new SpaceBookingResult
            { 
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                Email = userRequest.Email,
                DateRequested = userRequest.DateRequested
            };

        }
    }
}