using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IBodyRepository
    {
        Task<int> CreateBodyAsync(Body model);
    }
}
