using Microsoft.EntityFrameworkCore;
using VehicleFinder.Infrastructure;
using VehicleFinder.Entities;
using VehicleFinder.DTOs.ListingDTO;

namespace VehicleFinder.Services
{
    public class ListingService : IListingService
    {
        private readonly DatabaseContext _context;

        public ListingService(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GetListingDTO>> GetListingsAsync()
        {
            return await _context.Listings
                .Select(listing => new GetListingDTO
                {
                    CreationDate = listing.CreationDate,
                    Title = listing.Title,
                    Description = listing.Description,
                    Price = listing.Price,
                    IsSold = listing.IsSold,
                    UserId = listing.UserId,
                    VehicleId = listing.VehicleId
                })
                .ToListAsync();
        }

        public async Task<GetListingDTO> GetListingByIdAsync(int id)
        {
            var listing = await _context.Listings.FindAsync(id);

            if (listing == null)
            {
                return null;
            }

            return new GetListingDTO
            {
                CreationDate = listing.CreationDate,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                IsSold = listing.IsSold,
                UserId = listing.UserId,
                VehicleId = listing.VehicleId
            };
        }

        public async Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto)
        {
            var listing = new Listing
            {
                CreationDate = listingDto.CreationDate,
                Title = listingDto.Title,
                Description = listingDto.Description,
                Price = listingDto.Price,
                IsSold = listingDto.IsSold,
                UserId = listingDto.UserId,
                VehicleId = listingDto.VehicleId
            };

            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();

            return listingDto;
        }

        public async Task<bool> UpdateListingAsync(int id, CreateListingDTO listingDto)
        {
            var listing = await _context.Listings.FindAsync(id);
            if (listing == null)
            {
                return false;
            }

            listing.CreationDate = listingDto.CreationDate;
            listing.Title = listingDto.Title;
            listing.Description = listingDto.Description;
            listing.Price = listingDto.Price;
            listing.IsSold = listingDto.IsSold;
            listing.UserId = listingDto.UserId;
            listing.VehicleId = listingDto.VehicleId;

            _context.Entry(listing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListingExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<bool> DeleteListingAsync(int id)
        {
            var listing = await _context.Listings.FindAsync(id);
            if (listing == null)
            {
                return false;
            }

            _context.Listings.Remove(listing);
            await _context.SaveChangesAsync();

            return true;
        }

        private bool ListingExists(int id)
        {
            return _context.Listings.Any(e => e.Id == id);
        }
    }
}
