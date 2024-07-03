using VehicleFinder.DTOs;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services
{
    public interface IListingService
    {
        Task<IEnumerable<GetListingDTO>> GetListingsAsync();
        Task<IEnumerable<GetListingDTO>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<GetListingDTO> GetListingByIdAsync(Guid id);
        Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto);
        Task<bool> UpdateListingAsync(Guid id, CreateListingDTO listingDto);
        Task<bool> DeleteListingAsync(Guid id);
    }
}
