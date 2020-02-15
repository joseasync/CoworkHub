using System;

namespace OfficeBooker.BusinessRules
{
    internal class SpaceBookingRequestExecution
    {
        public SpaceBookingRequestExecution()
        {
        }

        internal SpaceBookingResult BookSpace(SpaceBookingRequest userRequest)
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