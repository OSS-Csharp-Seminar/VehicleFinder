using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> CreateVehicleAsync(Vehicle vehicle);
        Task<Vehicle> GetVehicleByIdAsync(Guid vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
    }
}
