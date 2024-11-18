using RentalMicroservice.Models;

namespace RentalMicroservice.Repositories
{
    public interface IRentalRepository
    {
        void CreateRental(CreateRentalItem createRentalItem);
        List<RentalItem> GetRentalItemsForUser(Guid userId);
        bool DoesUserHaveRentalForMovie(Guid movieId, Guid userId);
    }
}
