using RentalMicroservice.Models;

namespace RentalMicroservice.Services
{
    public interface IRentalService
    {
        void CreateRental(CreateRentalItem createRentalItem);
        List<RentalItem> GetRentalItemsForUser(Guid userId);
        bool DoesUserHaveRentalForMovie(Guid movieId, Guid userId);
    }
}
