using System.Threading.Tasks;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services.Implementation
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<IEnumerable<GetVehicleDTO>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();

            return vehicles.Select(vehicle => new GetVehicleDTO
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Kilometers = vehicle.Kilometers,
                ManufacturingYear = vehicle.ManufacturingYear,
                RegistrationUntil = vehicle.RegistrationUntil,
                NumberOfPreviousOwners = vehicle.NumberOfPreviousOwners
            }).ToList();
        }
        public async Task<Vehicle> CreateVehicleAsync(CreateVehicleDTO model)
        {
            var vehicle = new Vehicle
            {
                Brand = model.Brand,
                Model = model.Model,
                ManufacturingYear = model.ManufacturingYear,
                RegistrationUntil = model.RegistrationUntil,
                Kilometers = model.Kilometers,
                NumberOfPreviousOwners = model.NumberOfPreviousOwners
            };

            return await _vehicleRepository.CreateVehicleAsync(vehicle);
        }


        public async Task<GetVehicleDTO> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null)
            {
                return null;
            }

            return new GetVehicleDTO
            {
                Id = vehicle.Id,
                Brand = vehicle.Brand,
                Model = vehicle.Model,
                Kilometers = vehicle.Kilometers,
                ManufacturingYear = vehicle.ManufacturingYear,
                RegistrationUntil = vehicle.RegistrationUntil,
                NumberOfPreviousOwners = vehicle.NumberOfPreviousOwners
            };
        }
    }
}
