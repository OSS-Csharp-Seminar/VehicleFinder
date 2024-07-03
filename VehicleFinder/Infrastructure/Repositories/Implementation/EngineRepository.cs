using Microsoft.EntityFrameworkCore;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;

namespace VehicleFinder.Infrastructure.Repositories.Implementation
{
    public class EngineRepository : IEngineRepository
    {
        private readonly DatabaseContext _context;

        public EngineRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Engine>> GetAllEnginesAsync()
        {
            var engines = await _context.Engines.ToListAsync();
            if (engines == null)
            {
                throw new ArgumentNullException();
            }
            return engines;
        }

        public async Task<Engine> GetEngineByIdAsync(Guid Id)
        {
            var engine = await _context.Engines.FindAsync(Id);
            if (engine == null)
            {
                throw new ArgumentNullException();
            }
            return engine;
        }
        public async Task<Guid> CreateEngineAsync(Engine model)
        {
            _context.Engines.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
    }
}
