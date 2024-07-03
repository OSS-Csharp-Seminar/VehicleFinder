using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IBodyRepository
    {
        Task<Guid> CreateBodyAsync(Body model);
    }
}
