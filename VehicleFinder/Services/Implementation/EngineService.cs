using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Implementation;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services.Implementation
{
    public class EngineService : IEngineService
    {
        private readonly IEngineRepository _engineRepository;

        public EngineService(IEngineRepository engineRepository)
        {
            _engineRepository = engineRepository;
        }
        public async Task<int> CreateEngineAsync(CreateEngineDTO model)
        {
            var engine = new Engine
            {
                Name = model.Name,
                EngineCapacity = model.EngineCapacity,
                FuelType = model.FuelType.ToString(),
                Horsepower = model.Horsepower 
            };

            return await _engineRepository.CreateEngineAsync(engine);
        }
    }
}
