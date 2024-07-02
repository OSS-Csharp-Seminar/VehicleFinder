using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;

namespace VehicleFinder.Services.Interface
{
    public interface IVehicleService
    {
        Task<IEnumerable<GetVehicleDTO>> GetAllVehiclesAsync();
        Task<GetVehicleDTO>GetVehicleByIdAsync(string vehicleId);
        Task<Vehicle> CreateVehicleAsync(CreateVehicleDTO model);
        //Task<Vehicle> UpdateVehicleAsync(int id, Vehicle vehicle);
        //Task<bool> DeleteVehicleAsync(Vehicle vehicle);
    }
}
