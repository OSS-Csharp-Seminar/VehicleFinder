using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs;
using VehicleFinder.Services;

namespace VehicleFinder.Areas.Listing.Pages
{
    public class ListingDetailsModel : PageModel
    {
        private readonly IListingService _listingService;

        public ListingDetailsModel(IListingService listingService)
        {
            _listingService = listingService;
        }

        public GetGeneralListingDTO GeneralListing { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            GeneralListing = await _listingService.GetGeneralListingByIdAsync(id);

            if (GeneralListing == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
