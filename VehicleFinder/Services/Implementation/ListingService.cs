using Microsoft.EntityFrameworkCore;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
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
        public async Task<IEnumerable<GetListingDTO>> GetListingsByFilterAsync(ListingFilterDTO filter)
        {
            var listings = await _listingRepository.GetListingsByFilterAsync(filter);

            return listings.Select(l => new GetListingDTO
            {
                Id = l.Id,
                Title = l.Title,
                Description = l.Description,
                Price = l.Price,
                IsSold = l.IsSold,
                UserId = l.UserId,
                CreationDate = l.CreationDate,
                Vehicle = new GetVehicleDTO
                {
                    Id = l.Vehicle.Id,
                    Brand = l.Vehicle.Brand,
                    Model = l.Vehicle.Model,
                    ManufacturingYear = l.Vehicle.ManufacturingYear,
                    Kilometers = l.Vehicle.Kilometers,
                    RegistrationUntil = l.Vehicle.RegistrationUntil,
                    NumberOfPreviousOwners = l.Vehicle.NumberOfPreviousOwners,
                    Engine = new GetEngineDTO
                    {
                        Id = l.Vehicle.Engine.Id,
                        Name = l.Vehicle.Engine.Name,
                        FuelType = l.Vehicle.Engine.FuelType,
                        Horsepower = l.Vehicle.Engine.Horsepower,
                        EngineCapacity = l.Vehicle.Engine.EngineCapacity
                    },
                    Body = new GetBodyDTO
                    {
                        Id = l.Vehicle.Body.Id,
                        DoorCount = l.Vehicle.Body.DoorCount,
                        SeatCount = l.Vehicle.Body.SeatCount,
                        ACType = l.Vehicle.Body.ACType,
                        Color = l.Vehicle.Body.Color,
                        DrivetrainType = l.Vehicle.Body.DrivetrainType,
                        BodyShape = l.Vehicle.Body.BodyShape
                    }
                }
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
                Vehicle = new GetVehicleDTO
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
