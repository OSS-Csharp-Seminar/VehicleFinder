using Microsoft.EntityFrameworkCore;
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

        public async Task<Listing> GetListingByIdAsync(int id)
        {
            return await _context.Listings.FindAsync(id);
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

        public async Task DeleteListingAsync(int id)
        {
            var listing = await _context.Listings.FindAsync(id);
            if (listing != null)
            {
                _context.Listings.Remove(listing);
                await _context.SaveChangesAsync();
            }
        }

        public bool ListingExists(int id)
        {
            return _context.Listings.Any(e => e.Id == id);
        }
    }
}
