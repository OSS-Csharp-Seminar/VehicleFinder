using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TextTemplating;
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
        public async Task<Body> GetBodyByIdAsync(int Id)
        {
            var body = await _context.Bodies.FindAsync(Id);
            if (body == null)
            {
                throw new ArgumentNullException();
            }
            return body;
        }
        public bool BodyExists(int id)
        {
            return _context.Bodies.Any(e => e.Id == id);
        }

        public async Task UpdateBodyAsync(Body body)
        {
            _context.Entry(body).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
