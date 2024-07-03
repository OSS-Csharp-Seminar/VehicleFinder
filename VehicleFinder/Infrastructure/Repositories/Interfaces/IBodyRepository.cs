using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IBodyRepository
    {
        Task<string> CreateBodyAsync(Body model);
        Task<Body> GetBodyByIdAsync(string Id);
        Task UpdateBodyAsync(Body body);
        Task DeleteBodyAsync(string Id);
        public bool BodyExists(string id);
    }
}
