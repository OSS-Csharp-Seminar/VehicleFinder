using VehicleFinder.DTOs;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services
{
    public interface IListingService
    {
        Task<IEnumerable<GetListingDTO>> GetListingsAsync();
        Task<IEnumerable<GetListingDTO>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<GetListingDTO> GetListingByIdAsync(int id);
        Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto);
        Task<bool> UpdateListingAsync(int id, CreateListingDTO listingDto);
        Task<bool> DeleteListingAsync(int id);
    }
}
