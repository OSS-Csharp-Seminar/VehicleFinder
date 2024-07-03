using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services.Interface
{
    public interface IEngineService
    {
        //Task<IEnumerable<GetEngineDTO>> GetListingsAsync();
        //Task<GetEngineDTO> GetListingByIdAsync(int Id);
        Task<Guid> CreateEngineAsync(CreateEngineDTO model);
    }
}
