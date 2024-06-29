﻿using VehicleFinder.DTOs;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure.Repositories
{
    public interface IListingRepository
    {
        Task<IEnumerable<Listing>> GetListingsAsync();
        Task<IEnumerable<Listing>> GetListingsByFilterAsync(ListingFilterDTO filter);
        Task<Listing> GetListingByIdAsync(int id);
        Task AddListingAsync(Listing listing);
        Task UpdateListingAsync(Listing listing);
        Task DeleteListingAsync(int id);
        bool ListingExists(int id);
    }
}
