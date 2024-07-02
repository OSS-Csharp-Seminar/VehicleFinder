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

        public async Task<Engine> GetEngineByIdAsync(string Id)
        {
            var engine = await _context.Engines.FindAsync(Id);
            if (engine == null)
            {
                throw new ArgumentNullException();
            }
            return engine;
        }
        public async Task<string> CreateEngineAsync(Engine model)
        {
            _context.Engines.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
        public bool EngineExists(string id)
        {
            return _context.Engines.Any(e => e.Id == id);
        }

        public async Task UpdateEngineAsync(Engine engine)
        {
            _context.Entry(engine).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
