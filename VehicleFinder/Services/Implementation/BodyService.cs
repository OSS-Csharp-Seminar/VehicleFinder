using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services.Implementation
{
    public class BodyService : IBodyService
    {
        private readonly IBodyRepository _bodyRepository;

        public BodyService(IBodyRepository bodyRepository)
        {
            _bodyRepository = bodyRepository;
        }
        public async Task<int> CreateBodyAsync(CreateBodyDTO model)
        {
            var body = new Body
            {
                DoorCount = model.DoorCount,
                SeatCount = model.SeatCount,
                DrivetrainType = model.DrivetrainType,
                ACType = model.ACType,
                Color = model.Color,
                BodyShape = model.BodyShape
            };

        return await _bodyRepository.CreateBodyAsync(body);
        }
    }
}
