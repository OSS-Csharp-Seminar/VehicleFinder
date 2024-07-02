using VehicleFinder.DTOs;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services
{
    public interface IListingService
    {
        Task<IEnumerable<GetListingDTO>> GetListingsAsync();
        Task<IEnumerable<GetListingDTO>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<GetListingDTO> GetListingByIdAsync(string id);
        Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto);
        Task<GetGeneralListingDTO> GetGeneralListingByIdAsync(string id);
        Task<bool> UpdateListingAsync(string id, CreateListingDTO listingDto);
        Task<bool> UpdateListingAsync(UpdateGeneralListingDTO listingDto);
        Task<bool> DeleteListingAsync(string id);
    }
}
