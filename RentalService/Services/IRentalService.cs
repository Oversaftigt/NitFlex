using RentalService.Models;

namespace RentalService.Services
{
    public interface IRentalService
    {
        void CreateRental(CreateRentalItem createRentalItem);
        List<RentalItem> GetRentalItemsForUser(Guid userId);
        bool DoesUserHaveRentalForMovie(Guid movieId, Guid userId);
    }
}
