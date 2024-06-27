using VehicleFinder.DTOs.ListingDTO;

namespace VehicleFinder.Services
{
    public interface IListingService
    {
        Task<IEnumerable<GetListingDTO>> GetListingsAsync();
        Task<GetListingDTO> GetListingByIdAsync(int id);
        Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto);
        Task<bool> UpdateListingAsync(int id, CreateListingDTO listingDto);
        Task<bool> DeleteListingAsync(int id);
    }
}
