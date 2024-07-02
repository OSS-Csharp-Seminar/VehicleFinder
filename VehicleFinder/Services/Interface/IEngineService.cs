using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services.Interface
{
    public interface IEngineService
    {
        Task<GetEngineDTO> GetEngineByIdAsync(string Id);
        Task<string> CreateEngineAsync(CreateEngineDTO model);
    }
}
