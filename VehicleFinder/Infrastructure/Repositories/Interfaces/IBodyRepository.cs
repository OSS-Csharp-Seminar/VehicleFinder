using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IBodyRepository
    {
        Task<int> CreateBodyAsync(Body model);
        Task<Body> GetBodyByIdAsync(int Id);
        Task UpdateBodyAsync(Body body);
        public bool BodyExists(int id);
    }
}
