using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs;
using VehicleFinder.Entities;
using VehicleFinder.Services;

namespace VehicleFinder.Areas.Listing.Pages
{
    public class ListingDetailsModel : PageModel
    {
        private readonly IListingService _listingService;
        private readonly UserManager<User> _userManager;

        public ListingDetailsModel(IListingService listingService, UserManager<User> userManager)
        {
            _listingService = listingService;
            _userManager = userManager;
        }

        public GetGeneralListingDTO GeneralListing { get; set; }
        public string CurrentUserId { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            CurrentUserId = _userManager.GetUserId(User);
            GeneralListing = await _listingService.GetGeneralListingByIdAsync(id);

            if (GeneralListing == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
