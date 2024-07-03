using Microsoft.EntityFrameworkCore;
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
        public async Task<string> CreateBodyAsync(Body model)
        {
            _context.Bodies.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }
        public async Task<Body> GetBodyByIdAsync(string Id)
        {
            var body = await _context.Bodies.FindAsync(Id);
            if (body == null)
            {
                throw new ArgumentNullException();
            }
            return body;
        }
        public bool BodyExists(string id)
        {
            return _context.Bodies.Any(e => e.Id == id);
        }

        public async Task UpdateBodyAsync(Body body)
        {
            _context.Entry(body).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBodyAsync(string Id)
        {
            var body = await _context.Bodies.FindAsync(Id);
            if (body != null)
            {
                _context.Bodies.Remove(body);
                await _context.SaveChangesAsync();
            }
        }
    }
}
