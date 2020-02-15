using CoworkHub.Contracts.Models;

namespace CoworkHub.DAL.Interfaces
{
    public interface ISpaceBookingRepository
    {
        void Save(SpaceBooking spaceBooking);
    }
}
