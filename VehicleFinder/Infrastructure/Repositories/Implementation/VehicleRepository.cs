using Microsoft.EntityFrameworkCore;
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
        public async Task<Vehicle> GetVehicleByIdAsync(int vehicleId)
        {
            return await _context.Vehicles.FindAsync(vehicleId);
        }
        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return await _context.Vehicles.ToListAsync();
        }
    }
}
