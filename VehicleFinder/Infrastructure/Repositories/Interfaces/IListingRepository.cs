using VehicleFinder.DTOs;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories
{
    public interface IListingRepository
    {
        Task<IEnumerable<Listing>> GetListingsAsync();
        Task<IEnumerable<Listing>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<Listing> GetListingByIdAsync(Guid id);
        Task AddListingAsync(Listing listing);
        Task UpdateListingAsync(Listing listing);
        Task DeleteListingAsync(Guid id);
        bool ListingExists(Guid id);
    }
}
