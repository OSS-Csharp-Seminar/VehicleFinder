using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.General;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Services.Interface;

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

        public async Task<IEnumerable<GetListingDTO>> GetListingsByFilterAsync(ListingFilterDTO filter)
        {
            var listings = await _listingRepository.GetListingsByFilterAsync(filter);
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

            // Update listing properties
            _mapper.Map(listingDto.Listing, listing);

            // Update vehicle properties
            var vehicle = await _vehicleRepository.GetVehicleByIdAsync(listingDto.Vehicle.Id);
            if (vehicle == null)
            {
                return false;
            }
            _mapper.Map(listingDto.Vehicle, vehicle);

            // Update engine properties
            var engine = await _engineRepository.GetEngineByIdAsync(listingDto.Engine.Id);
            if (engine == null)
            {
                return false;
            }
            _mapper.Map(listingDto.Engine, engine);

            // Update body properties
            var body = await _bodyRepository.GetBodyByIdAsync(listingDto.Body.Id);
            if (body == null)
            {
                return false;
            }
            _mapper.Map(listingDto.Body, body);

            try
            {
                await _listingRepository.UpdateListingAsync(listing);
                await _vehicleRepository.UpdateVehicleAsync(vehicle);
                await _engineRepository.UpdateEngineAsync(engine);
                await _bodyRepository.UpdateBodyAsync(body);
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_listingRepository.ListingExists(listingDto.Listing.Id) ||
                    !_vehicleRepository.VehicleExists(listingDto.Vehicle.Id) ||
                    !_engineRepository.EngineExists(listingDto.Engine.Id) ||
                    !_bodyRepository.BodyExists(listingDto.Body.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<bool> DeleteListingAsync(string id)
        {
            var listing = await _listingRepository.GetListingByIdAsync(id);
            if (listing == null)
            {
                return false;
            }

            await _listingRepository.DeleteListingAsync(id);
            return true;
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
    }
}
