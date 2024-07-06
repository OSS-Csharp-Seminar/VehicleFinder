using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.Entities;
using VehicleFinder.Enums;
using VehicleFinder.Services;
using VehicleFinder.Helper;

namespace VehicleFinder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IListingService _listingService;
        private readonly UserManager<User> _userManager;

        public IndexModel(IListingService listingService, UserManager<User> userManager)
        {
            _listingService = listingService;
            _userManager = userManager;
        }

        [BindProperty(SupportsGet = true)]
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public CarManufacturer? Brand { get; set; }
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
        public string? EngineName { get; set; }
        [BindProperty(SupportsGet = true)]
        public FuelType? FuelType { get; set; }
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

        [BindProperty(SupportsGet = true)]
        public string? SearchQuery { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SortBy { get; set; }

        [BindProperty(SupportsGet = true)]
        public int PageIndex { get; set; } = 1;
        public PaginatedList<GetListingDTO> Listings { get; set; }
        public string CurrentUserId { get; set; }

        public List<SelectListItem> FuelTypeOptions { get; set; }
        public List<SelectListItem> BodyShapeOptions { get; set; }
        public List<SelectListItem> ACTypeOptions { get; set; }
        public List<SelectListItem> CarManufacturers { get; set; }
        public List<SelectListItem> DrivetrainTypeOptions { get; set; }
        public List<SelectListItem> ShifterTypeOptions { get; set; }

        public async Task OnGetAsync()
        {
            CurrentUserId = _userManager.GetUserId(User);

            var filter = new ListingFilterDTO
            {
                SearchQuery = SearchQuery,
                Title = Title,
                Brand = Brand,
                Model = Model,
                YearMin = YearMin,
                YearMax = YearMax,
                PriceMin = PriceMin,
                PriceMax = PriceMax,
                IsSold = IsSold,
                EngineName = EngineName,
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

            int pageSize = 10;
            Listings = await _listingService.GetPaginatedListingsByFilterAsync(filter, PageIndex, pageSize, SortBy);

            FuelTypeOptions = GetEnumSelectList<FuelType>(FuelType);
            BodyShapeOptions = GetEnumSelectList<BodyShape>(BodyShape);
            ACTypeOptions = GetEnumSelectList<ACType>(ACType);
            DrivetrainTypeOptions = GetEnumSelectList<DrivetrainType>(DrivetrainType);
            ShifterTypeOptions = GetEnumSelectList<ShifterType>(ShifterType);
            CarManufacturers = GetEnumSelectList<CarManufacturer>(Brand);
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
