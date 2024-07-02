using VehicleFinder.DTOs.BodyDTO;

namespace VehicleFinder.Services.Interface
{
    public interface IBodyService
    {
        Task<string> CreateBodyAsync(CreateBodyDTO body);
        Task<GetBodyDTO> GetBodyByIdAsync(string id);
    }
}
