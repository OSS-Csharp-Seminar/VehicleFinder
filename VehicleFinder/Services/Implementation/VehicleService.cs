using AutoMapper;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services.Implementation
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IMapper mapper, IVehicleRepository vehicleRepository)
        {
            _mapper = mapper;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<IEnumerable<GetVehicleDTO>> GetAllVehiclesAsync()
        {
            var vehicles = await _vehicleRepository.GetAllVehiclesAsync();
            return _mapper.Map<IEnumerable<GetVehicleDTO>>(vehicles);
        }

        public async Task<Vehicle> CreateVehicleAsync(CreateVehicleDTO model)
        {
            var vehicle = _mapper.Map<Vehicle>(model);
            return await _vehicleRepository.CreateVehicleAsync(vehicle);
        }

        public async Task<GetVehicleDTO> GetVehicleByIdAsync(string vehicleId)
        {
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null)
            {
                return null;
            }
            return _mapper.Map<GetVehicleDTO>(vehicle);
        }
    }
}
