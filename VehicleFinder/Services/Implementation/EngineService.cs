using AutoMapper;
using System.Threading.Tasks;
using VehicleFinder.DTOs.BodyDTO;
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
        private readonly IMapper _mapper;

        public EngineService(IMapper mapper, IEngineRepository engineRepository)
        {
            _mapper = mapper;
            _engineRepository = engineRepository;
        }

        public async Task<string> CreateEngineAsync(CreateEngineDTO model)
        {
            var engine = _mapper.Map<Engine>(model);
            return await _engineRepository.CreateEngineAsync(engine);
        }

        public async Task<GetEngineDTO> GetEngineByIdAsync(string Id)
        {
            var engine = await _engineRepository.GetEngineByIdAsync(Id);
            if (engine == null)
            {
                return null;
            }
            return _mapper.Map<GetEngineDTO>(engine);
        }
    }
}
