using Microsoft.EntityFrameworkCore;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories;

namespace VehicleFinder.Services
{
    public class ListingService : IListingService
    {
        private readonly IListingRepository _listingRepository;

        public ListingService(IListingRepository listingRepository)
        {
            _listingRepository = listingRepository;
        }

        public async Task<IEnumerable<GetListingDTO>> GetListingsAsync()
        {
            var listings = await _listingRepository.GetListingsAsync();

            return listings.Select(listing => new GetListingDTO
            {
                Id = listing.Id,
                CreationDate = listing.CreationDate,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                IsSold = listing.IsSold,
                UserId = listing.UserId,
                VehicleId = listing.VehicleId
            }).ToList();
        }

        public async Task<GetListingDTO> GetListingByIdAsync(int id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);

            if (listing == null)
            {
                return null;
            }

            return new GetListingDTO
            {
                Id = listing.Id,
                CreationDate = listing.CreationDate,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                IsSold = listing.IsSold,
                UserId = listing.UserId,
                VehicleId = listing.VehicleId
            };
        }

        public async Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto, Vehicle vehicle)
        {
            var listing = new Listing
            {
                CreationDate = listingDto.CreationDate,
                Title = listingDto.Title,
                Description = listingDto.Description,
                Price = listingDto.Price,
                IsSold = listingDto.IsSold,
                UserId = listingDto.UserId,
                VehicleId = vehicle.Id
            };

            await _listingRepository.AddListingAsync(listing);

            return listingDto;
        }

        public async Task<bool> UpdateListingAsync(int id, CreateListingDTO listingDto)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            listing.CreationDate = listingDto.CreationDate;
            listing.Title = listingDto.Title;
            listing.Description = listingDto.Description;
            listing.Price = listingDto.Price;
            listing.UserId = listingDto.UserId;
            //listing.VehicleId = listingDto.VehicleId;

            try
            {
                await _listingRepository.UpdateListingAsync(listing);
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_listingRepository.ListingExists(id))
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
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            await _listingRepository.DeleteListingAsync(id);

            return true;
        }
    }
}
