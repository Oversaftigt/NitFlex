using RentalService.Models;

namespace RentalService.Services
{
    public class RentalService: IRentalService
    {
        void IRentalService.CreateRental(CreateRentalItem createRentalItem)
        {
            throw new NotImplementedException();
        }

        List<RentalItem> IRentalService.GetRentalItemsForUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        bool IRentalService.DoesUserHaveRentalForMovie(Guid movieId, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
