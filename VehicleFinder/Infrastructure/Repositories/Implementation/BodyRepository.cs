using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;

namespace VehicleFinder.Infrastructure.Repositories.Implementation
{
    public class BodyRepository : IBodyRepository
    {
        private readonly DatabaseContext _context;

        public BodyRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<int> CreateBodyAsync(Body model)
        {
            _context.Bodies.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
    }
}
