using VehicleFinder.DTOs.BodyDTO;

namespace VehicleFinder.Services.Interface
{
    public interface IBodyService
    {
        Task<int> CreateBodyAsync(CreateBodyDTO body);
        Task<GetBodyDTO> GetBodyByIdAsync(int id);
    }
}
