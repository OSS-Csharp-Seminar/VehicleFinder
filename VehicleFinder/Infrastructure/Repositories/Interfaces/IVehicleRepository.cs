using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> CreateVehicleAsync(Vehicle vehicle);
        Task<Vehicle> GetVehicleByIdAsync(int vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task UpdateVehicleAsync(Vehicle vehicle);

        bool VehicleExists(int id);

    }
}
