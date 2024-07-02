using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Task<Vehicle> CreateVehicleAsync(Vehicle vehicle);
        Task<Vehicle> GetVehicleByIdAsync(string vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task UpdateVehicleAsync(Vehicle vehicle);

        bool VehicleExists(string id);

    }
}
