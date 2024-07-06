using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Helper;
using VehicleFinder.Infrastructure.Repositories;
using VehicleFinder.Infrastructure.Repositories.Interfaces;

namespace VehicleFinder.Services
{
    public class ListingService : IListingService
    {
        private readonly IListingRepository _listingRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IEngineRepository _engineRepository;
        private readonly IBodyRepository _bodyRepository;
        private readonly IMapper _mapper;

        public ListingService(IListingRepository listingRepository, IVehicleRepository vehicleRepository, IEngineRepository engineRepository, IBodyRepository bodyRepository, IMapper mapper)
        {
            _listingRepository = listingRepository;
            _vehicleRepository = vehicleRepository;
            _engineRepository = engineRepository;
            _bodyRepository = bodyRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetListingDTO>> GetListingsAsync()
        {
            var listings = await _listingRepository.GetListingsAsync();
            var listingDTOs = _mapper.Map<IEnumerable<GetListingDTO>>(listings);
            return listingDTOs;
        }

        public async Task<GetListingDTO> GetListingByIdAsync(string id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return null!;
            }

            var listingDTO = _mapper.Map<GetListingDTO>(listing);
            return listingDTO;
        }

        public async Task<CreateListingDTO> CreateListingAsync(CreateListingDTO listingDto)
        {
            var listing = _mapper.Map<Listing>(listingDto);
            await _listingRepository.AddListingAsync(listing);
            return listingDto;
        }

        public async Task<bool> MarkAsSoldAsync(string id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            listing.IsSold = true;
            await _listingRepository.UpdateListingAsync(listing);

            return true;
        }

        public async Task<bool> UpdateListingAsync(string id, CreateListingDTO listingDto)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            _mapper.Map(listingDto, listing);

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

        public async Task<bool> UpdateListingAsync(UpdateGeneralListingDTO listingDto)
        {
            var listing = await _listingRepository.GetListingByIdAsync(listingDto.Listing.Id);
            if (listing == null)
            {
                return false;
            }

            bool updateSuccessful = true;

            if (!string.IsNullOrEmpty(listingDto.Vehicle.Id))
            {
                var vehicle = await _vehicleRepository.GetVehicleByIdAsync(listingDto.Vehicle.Id);
                if (vehicle != null)
                {
                    _mapper.Map(listingDto.Vehicle, vehicle);
                    await _vehicleRepository.UpdateVehicleAsync(vehicle);
                }
                else
                {
                    updateSuccessful = false;
                }
            }


            if (!string.IsNullOrEmpty(listingDto.Engine.Id))
            {
                var engine = await _engineRepository.GetEngineByIdAsync(listingDto.Engine.Id);
                if (engine != null)
                {
                    _mapper.Map(listingDto.Engine, engine);
                    await _engineRepository.UpdateEngineAsync(engine);
                }
                else
                {
                    updateSuccessful = false;
                }
            }

            if (!string.IsNullOrEmpty(listingDto.Body.Id))
            {
                var body = await _bodyRepository.GetBodyByIdAsync(listingDto.Body.Id);
                if (body != null)
                {
                    _mapper.Map(listingDto.Body, body);
                    await _bodyRepository.UpdateBodyAsync(body);
                }
                else
                {
                    updateSuccessful = false;
                }
            }

            try
            {
                if (updateSuccessful)
                {
                    _mapper.Map(listingDto.Listing, listing);
                    await _listingRepository.UpdateListingAsync(listing);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return false;
            }
        }



        public async Task<bool> DeleteListingAsync(string id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(listing.VehicleId);
            var body = await _bodyRepository.GetBodyByIdAsync(vehicle.BodyId);

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (body != null)
                    {
                        await _bodyRepository.DeleteBodyAsync(body.Id);
                    }
                    if (vehicle != null)
                    {
                        await _vehicleRepository.DeleteVehicleAsync(vehicle.Id);
                    }
                    await _listingRepository.DeleteListingAsync(id);

                    scope.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to delete listing with dependencies.", ex);
                }
            }
        }

        public async Task<GetGeneralListingDTO> GetGeneralListingByIdAsync(string id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return null;
            }

            var generalListing = new GetGeneralListingDTO
            {
                Listing = _mapper.Map<GetListingDTO>(listing),
                Vehicle = _mapper.Map<GetVehicleDTO>(listing.Vehicle),
                Engine = _mapper.Map<GetEngineDTO>(listing.Vehicle.Engine),
                Body = _mapper.Map<GetBodyDTO>(listing.Vehicle.Body)
            };

            return generalListing;
        }

        public async Task<PaginatedList<GetListingDTO>> GetPaginatedListingsByFilterAsync(ListingFilterDTO filter, int pageIndex, int pageSize, string sortBy)
        {
            var paginatedListings = await _listingRepository.GetPaginatedListingsByFilterAsync(filter, pageIndex, pageSize, sortBy);
            var listingDTOs = _mapper.Map<IEnumerable<GetListingDTO>>(paginatedListings);
            return new PaginatedList<GetListingDTO>(listingDTOs.ToList(), paginatedListings.TotalCount, pageIndex, pageSize);
        }

    }
}
