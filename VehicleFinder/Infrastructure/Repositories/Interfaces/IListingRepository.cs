using VehicleFinder.DTOs;
using VehicleFinder.Entities;
using VehicleFinder.Helper;

namespace VehicleFinder.Infrastructure.Repositories
{
    public interface IListingRepository
    {
        Task<IEnumerable<Listing>> GetListingsAsync();
        Task<IEnumerable<Listing>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<PaginatedList<Listing>> GetPaginatedListingsByFilterAsync(ListingFilterDTO filter, int pageIndex, int pageSize);
        Task<Listing> GetListingByIdAsync(string id);
        Task AddListingAsync(Listing listing);
        Task UpdateListingAsync(Listing listing);
        Task DeleteListingAsync(string id);
        bool ListingExists(string id);
    }
}
