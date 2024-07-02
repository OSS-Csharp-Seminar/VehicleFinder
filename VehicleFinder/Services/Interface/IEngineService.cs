using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services.Interface
{
    public interface IEngineService
    {
        Task<GetEngineDTO> GetEngineByIdAsync(int Id);
        Task<int> CreateEngineAsync(CreateEngineDTO model);
    }
}
