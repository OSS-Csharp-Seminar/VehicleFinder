using VehicleFinder.DTOs.EngineDTO;

namespace VehicleFinder.Services.Interface
{
    public interface IEngineService
    {

        Task<IEnumerable<GetEngineDTO>> GetAllEnginesAsync();
        Task<GetEngineDTO> GetEngineByIdAsync(string Id);
        Task<string> CreateEngineAsync(CreateEngineDTO model);
    }
}
