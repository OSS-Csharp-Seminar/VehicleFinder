using VehicleFinder.DTOs;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Helper;

namespace VehicleFinder.Services
{
    public interface IListingService
    {
        Task<IEnumerable<GetListingDTO>> GetListingsAsync();
        Task<GetListingDTO> GetListingByIdAsync(string id);
        Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto);
        Task<GetGeneralListingDTO> GetGeneralListingByIdAsync(string id);
        Task<bool> MarkAsSoldAsync(string id);
        Task<bool> UpdateListingAsync(string id, CreateListingDTO listingDto);
        Task<bool> UpdateListingAsync(UpdateGeneralListingDTO listingDto);
        Task<bool> DeleteListingAsync(string id);
        Task<PaginatedList<GetListingDTO>> GetPaginatedListingsByFilterAsync(ListingFilterDTO filter, int pageIndex, int pageSize);
    }
}
