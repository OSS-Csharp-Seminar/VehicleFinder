using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VehicleFinder.DTOs;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories
{
    public class ListingRepository : IListingRepository
    {
        private readonly DatabaseContext _context;

        public ListingRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Listing>> GetListingsAsync()
        {
            return await _context.Listings.ToListAsync();
        }
        public async Task<IEnumerable<Listing>> GetListingsByFilterAsync(ListingFilterDTO filter)
        {
            var query = _context.Listings
                                .Include(l => l.Vehicle)
                                .ThenInclude(v => v.Engine)
                                .Include(l => l.Vehicle)
                                .ThenInclude(v => v.Body)
                                .AsQueryable();

            if (!string.IsNullOrEmpty(filter.Title))
            {
                string lowerTitle = filter.Title.ToLower();
                query = query.Where(l => l.Title.ToLower().Contains(lowerTitle));
            }

            if (!string.IsNullOrEmpty(filter.Brand))
            {
                string lowerBrand = filter.Brand.ToLower();
                query = query.Where(l => l.Vehicle.Brand.ToLower().Contains(lowerBrand));
            }

            if (!string.IsNullOrEmpty(filter.Model))
            {
                string lowerModel = filter.Model.ToLower();
                query = query.Where(l => l.Vehicle.Model.ToLower().Contains(lowerModel));
            }

            if (filter.YearMin.HasValue)
            {
                query = query.Where(l => l.Vehicle.ManufacturingYear >= filter.YearMin.Value);
            }

            if (filter.YearMax.HasValue)
            {
                query = query.Where(l => l.Vehicle.ManufacturingYear <= filter.YearMax.Value);
            }

            if (filter.PriceMin.HasValue)
            {
                query = query.Where(l => l.Price >= filter.PriceMin.Value);
            }

            if (filter.PriceMax.HasValue)
            {
                query = query.Where(l => l.Price <= filter.PriceMax.Value);
            }

            if (filter.IsSold.HasValue)
            {
                query = query.Where(l => l.IsSold == filter.IsSold.Value);
            }

            if (!string.IsNullOrEmpty(filter.EngineName))
            {
                string lowerEngineName = filter.EngineName.ToLower();
                query = query.Where(l => l.Vehicle.Engine.Name.ToLower().Contains(lowerEngineName));
            }

            if (filter.FuelType.HasValue)
            {
                query = query.Where(l => l.Vehicle.Engine.FuelType == filter.FuelType.Value);
            }

            if (filter.HorsepowerMin.HasValue)
            {
                query = query.Where(l => l.Vehicle.Engine.Horsepower >= filter.HorsepowerMin.Value);
            }

            if (filter.HorsepowerMax.HasValue)
            {
                query = query.Where(l => l.Vehicle.Engine.Horsepower <= filter.HorsepowerMax.Value);
            }

            if (filter.DoorCount.HasValue)
            {
                query = query.Where(l => l.Vehicle.Body.DoorCount == filter.DoorCount.Value);
            }

            if (filter.SeatCount.HasValue)
            {
                query = query.Where(l => l.Vehicle.Body.SeatCount == filter.SeatCount.Value);
            }

            if (filter.BodyShape.HasValue)
            {
                query = query.Where(l => l.Vehicle.Body.BodyShape == filter.BodyShape.Value);
            }

            if (filter.ACType.HasValue)
            {
                query = query.Where(l => l.Vehicle.Body.ACType == filter.ACType.Value);
            }

            if (filter.DrivetrainType.HasValue)
            {
                query = query.Where(l => l.Vehicle.Body.DrivetrainType == filter.DrivetrainType.Value);
            }

            if (filter.ShifterType.HasValue)
            {
                query = query.Where(l => l.Vehicle.ShifterType == filter.ShifterType.Value);
            }

            return await query.ToListAsync();
        }

        public async Task<Listing> GetListingByIdAsync(string id)
        {
            return await _context.Listings
                                 .Include(l => l.Vehicle)
                                 .ThenInclude(v => v.Engine)
                                 .Include(l => l.Vehicle)
                                 .ThenInclude(v => v.Body)
                                 .FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddListingAsync(Listing listing)
        {
            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateListingAsync(Listing listing)
        {
            _context.Entry(listing).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteListingAsync(string id)
        {
            var listing = await _context.Listings.FindAsync(id);
            if (listing != null)
            {
                _context.Listings.Remove(listing);
                await _context.SaveChangesAsync();
            }
        }

        public bool ListingExists(string id)
        {
            return _context.Listings.Any(e => e.Id == id);
        }
    }
}
