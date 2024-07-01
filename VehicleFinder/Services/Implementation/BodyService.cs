using AutoMapper;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services.Implementation
{
    public class BodyService : IBodyService
    {
        private readonly IBodyRepository _bodyRepository;
        private readonly IMapper _mapper;

        public BodyService(IMapper mapper, IBodyRepository bodyRepository)
        {
            _mapper = mapper;
            _bodyRepository = bodyRepository;
        }
        public async Task<int> CreateBodyAsync(CreateBodyDTO model)
        {
            var body = _mapper.Map<Body>(model);

            return await _bodyRepository.CreateBodyAsync(body);
        }
    }
}
