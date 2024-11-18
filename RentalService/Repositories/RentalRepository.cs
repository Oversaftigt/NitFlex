using RentalMicroservice.Models;

namespace RentalMicroservice.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        void IRentalRepository.CreateRental(CreateRentalItem createRentalItem)
        {
            throw new NotImplementedException();
        }

        List<RentalItem> IRentalRepository.GetRentalItemsForUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        bool IRentalRepository.DoesUserHaveRentalForMovie(Guid movieId, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
