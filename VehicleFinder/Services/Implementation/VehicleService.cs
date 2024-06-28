﻿using System.Threading.Tasks;
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

        public async Task<IEnumerable<GetEngineDTO>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();

            return vehicles.Select(vehicle => new GetEngineDTO
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
                NumberOfPreviousOwners = model.NumberOfPreviousOwners,
                EngineId = model.EngineId,
                BodyId = model.BodyId,
            };

            return await _vehicleRepository.CreateVehicleAsync(vehicle);
        }


        public async Task<GetEngineDTO> GetVehicleByIdAsync(int vehicleId)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null)
            {
                return null;
            }

            return new GetEngineDTO
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
