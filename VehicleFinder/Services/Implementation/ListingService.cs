using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Services
{
    public class ListingService : IListingService
    {
        private readonly IListingRepository _listingRepository;
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public ListingService(IListingRepository listingRepository, IVehicleService vehicleService, IMapper mapper)
        {
            _listingRepository = listingRepository;
            _vehicleService = vehicleService;
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

        public async Task<GetListingDTO> GetListingByIdAsync(int id)
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

        public async Task<bool> UpdateListingAsync(int id, CreateListingDTO listingDto)
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
