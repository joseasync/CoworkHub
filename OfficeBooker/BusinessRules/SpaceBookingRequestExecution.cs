using CoworkHub.DAL.Interfaces;
using CoworkHub.Contracts.Models;
using System;

namespace CoworkHub.OfficeBooker.BusinessRules
{
    public class SpaceBookingRequestExecution
    {
        private readonly ISpaceBookingRepository _repository;

        public SpaceBookingRequestExecution(ISpaceBookingRepository repository)
        {
            _repository = repository;
        }


        public SpaceBookingResult BookSpace(SpaceBookingRequest userRequest)
        {
            if (userRequest == null)
            {
                throw new ArgumentNullException(nameof(userRequest));
            }

            _repository.Save(Create<SpaceBooking>(userRequest));

            return Create<SpaceBookingResult>(userRequest);
        }

        private T Create<T>(SpaceBookingRequest userRequest) where T : SpaceBookingBase, new()
        {
            return new T
            {
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                Email = userRequest.Email,
                DateRequested = userRequest.DateRequested
            };
        }
    }
}