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
    }
}
