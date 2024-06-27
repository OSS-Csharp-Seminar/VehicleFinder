using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Services;

namespace VehicleFinder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IListingService _listingService;

        public IndexModel(ILogger<IndexModel> logger, IListingService listingService)
        {
            _logger = logger;
            _listingService = listingService;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public float? PriceMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public float? PriceMax { get; set; }

        public List<GetListingDTO> Listings { get; set; }

        public async Task OnGetAsync()
        {
            Listings = (List<GetListingDTO>)await _listingService.GetListingsAsync();

            if (!string.IsNullOrEmpty(Title))
            {
                Listings = Listings.FindAll(l => l.Title.Contains(Title));
            }

            if (PriceMin.HasValue)
            {
                Listings = Listings.FindAll(l => l.Price >= PriceMin.Value);
            }

            if (PriceMax.HasValue)
            {
                Listings = Listings.FindAll(l => l.Price <= PriceMax.Value);
            }
        }
    }
}
