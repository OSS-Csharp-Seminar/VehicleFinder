using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;
using VehicleFinder.Enums;
using VehicleFinder.Services;

namespace VehicleFinder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IListingService _listingService;
        private readonly UserManager<User> _userManager;

        public IndexModel(ILogger<IndexModel> logger, IListingService listingService, UserManager<User> userManager)
        {
            _logger = logger;
            _listingService = listingService;
            _userManager = userManager;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Brand { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Model { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? YearMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? YearMax { get; set; }
        [BindProperty(SupportsGet = true)]
        public float? PriceMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public float? PriceMax { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool? IsSold { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? FuelType { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? HorsepowerMin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? HorsepowerMax { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? DoorCount { get; set; }
        [BindProperty(SupportsGet = true)]
        public int? SeatCount { get; set; }
        [BindProperty(SupportsGet = true)]
        public BodyShape? BodyShape { get; set; }
        [BindProperty(SupportsGet = true)]
        public ACType? ACType { get; set; }
        [BindProperty(SupportsGet = true)]
        public DrivetrainType? DrivetrainType { get; set; }
        [BindProperty(SupportsGet = true)]
        public ShifterType? ShifterType { get; set; }

        public IEnumerable<GetListingDTO> Listings { get; set; }
        public string CurrentUserId { get; set; }

        public List<SelectListItem> FuelTypeOptions { get; set; }
        public List<SelectListItem> BodyShapeOptions { get; set; }
        public List<SelectListItem> ACTypeOptions { get; set; }
        public List<SelectListItem> DrivetrainTypeOptions { get; set; }
        public List<SelectListItem> ShifterTypeOptions { get; set; }

        public async Task OnGetAsync()
        {
            var filter = new ListingFilterDTO
            {
                Title = Title,
                Brand = Brand,
                Model = Model,
                YearMin = YearMin,
                YearMax = YearMax,
                PriceMin = PriceMin,
                PriceMax = PriceMax,
                IsSold = IsSold,
                FuelType = FuelType,
                HorsepowerMin = HorsepowerMin,
                HorsepowerMax = HorsepowerMax,
                DoorCount = DoorCount,
                SeatCount = SeatCount,
                BodyShape = BodyShape,
                ACType = ACType,
                DrivetrainType = DrivetrainType,
                ShifterType = ShifterType
            };

            Listings = await _listingService.GetListingsByFilterAsync(filter);

            //FuelTypeOptions = GetEnumSelectList<FuelType>(FuelType);
            BodyShapeOptions = GetEnumSelectList<BodyShape>(BodyShape);
            ACTypeOptions = GetEnumSelectList<ACType>(ACType);
            DrivetrainTypeOptions = GetEnumSelectList<DrivetrainType>(DrivetrainType);
            ShifterTypeOptions = GetEnumSelectList<ShifterType>(ShifterType);
        }

        private List<SelectListItem> GetEnumSelectList<TEnum>(TEnum? selectedValue) where TEnum : struct
        {
            var enumValues = Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
            return enumValues.Select(e => new SelectListItem
            {
                Value = e.ToString(),
                Text = e.ToString(),
                Selected = selectedValue.HasValue && selectedValue.Value.Equals(e)
            }).ToList();
        }
    }
}
