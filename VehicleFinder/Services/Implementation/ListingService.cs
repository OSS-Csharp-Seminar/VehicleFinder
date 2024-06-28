using Microsoft.EntityFrameworkCore;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services
{
    public class ListingService : IListingService
    {
        private readonly IListingRepository _listingRepository;
        private readonly IVehicleService _vehicleService;

        public ListingService(IListingRepository listingRepository, IVehicleService vehicleService)
        {
            _listingRepository = listingRepository;
            _vehicleService = vehicleService;
        }

        public async Task<IEnumerable<GetListingDTO>> GetListingsAsync()
        {
            var listings = await _listingRepository.GetListingsAsync();
            var vehicles = await _vehicleService.GetAllVehiclesAsync();

            if (vehicles == null)
            {
                return null!;
            }

            var vehicleDict = vehicles.ToDictionary(v => v.Id);

            return listings.Select(listing => new GetListingDTO
            {
                Id = listing.Id,
                CreationDate = listing.CreationDate,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                UserId = listing.UserId,
                IsSold = listing.IsSold,
                Vehicle = vehicleDict[listing.VehicleId]
            }).ToList();
        }

        public async Task<GetListingDTO> GetListingByIdAsync(int id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);

            if (listing == null)
            {
                return null!;
            }

            return new GetListingDTO
            {
                Id = listing.Id,
                CreationDate = listing.CreationDate,
                Title = listing.Title,
                Description = listing.Description,
                Price = listing.Price,
                UserId = listing.UserId,
                IsSold = listing.IsSold,
                Vehicle = new GetEngineDTO
                {
                    Id = listing.Vehicle.Id,
                    Brand = listing.Vehicle.Brand,
                    Model = listing.Vehicle.Model,
                    Kilometers = listing.Vehicle.Kilometers,
                    ManufacturingYear = listing.Vehicle.ManufacturingYear,
                    RegistrationUntil = listing.Vehicle.RegistrationUntil,
                    NumberOfPreviousOwners = listing.Vehicle.NumberOfPreviousOwners
                }
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
