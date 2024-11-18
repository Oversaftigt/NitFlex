using RentalService.Models;

namespace RentalService.Repositories
{
    public interface IRentalRepository
    {
        void CreateRental(CreateRentalItem createRentalItem);
        List<RentalItem> GetRentalItemsForUser(Guid userId);
        bool DoesUserHaveRentalForMovie(Guid movieId, Guid userId);
    }
}
