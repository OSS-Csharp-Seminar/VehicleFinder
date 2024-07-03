using VehicleFinder.DTOs.BodyDTO;

namespace VehicleFinder.Services.Interface
{
    public interface IBodyService
    {
        Task<Guid> CreateBodyAsync(CreateBodyDTO body);
    }
}
