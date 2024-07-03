using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading.Tasks;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories.Interfaces;

namespace VehicleFinder.Infrastructure.Repositories.Implementation
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DatabaseContext _context;

        public VehicleRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Vehicle> CreateVehicleAsync(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
        public async Task<Vehicle> GetVehicleByIdAsync(string vehicleId)
        {
            return await _context.Vehicles.FindAsync(vehicleId);
        }
        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }
        public bool VehicleExists(string id)
        {
            return _context.Vehicles.Any(e => e.Id == id);
        }

        public async Task UpdateVehicleAsync(Vehicle vehicle)
        {
            _context.Entry(vehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteVehicleAsync(string Id)
        {
            var vehicle = await _context.Vehicles.FindAsync(Id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();
            }
        }
    }
}
