using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs.General;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.Entities;
using VehicleFinder.Enums;
using VehicleFinder.Services;
using VehicleFinder.Services.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VehicleFinder.Areas.Listing.Pages
{
    public class CreateListingModel : PageModel
    {
        private readonly IListingService _listingService;
        private readonly IVehicleService _vehicleService;
        private readonly IEngineService _engineService;
        private readonly IBodyService _bodyService;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<CreateListingModel> _logger;

        public CreateListingModel(IListingService listingService, IVehicleService vehicleService, IEngineService engineService, IBodyService bodyService, UserManager<User> userManager, ILogger<CreateListingModel> logger)
        {
            _listingService = listingService;
            _vehicleService = vehicleService;
            _engineService = engineService;
            _bodyService = bodyService;
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public CreateGeneralListingDTO GeneralListing { get; set; }
        [BindProperty]
        public string? SelectedEngineId { get; set; }
        [BindProperty]
        public bool IsNewEngine { get; set; }
        public List<SelectListItem> EngineList { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            InitializeDefaultCreateGeneralListing();
            EngineList = (await _engineService.GetAllEnginesAsync()).Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Name
            }).ToList();

            return Page();
        }

        private void InitializeDefaultCreateGeneralListing()
        {
            GeneralListing = new CreateGeneralListingDTO
            {
                Listing = new CreateListingDTO
                {
                    Title = "Default Title",
                    Description = "Default Description",
                    ContactNumber = "0991001000",
                    Price = 20000
                },
                Vehicle = new CreateVehicleDTO
                {
                    Brand = CarManufacturer.Abarth,
                    Model = "Default Model",
                    ManufacturingYear = DateTime.Now.Year,
                    RegistrationUntil = DateOnly.FromDateTime(DateTime.Now.AddYears(1)),
                    Kilometers = new Random().Next(0, 100000),
                    NumberOfPreviousOwners = new Random().Next(1, 5),
                    ShifterType = ShifterType.Automatic,
                    GearCount = new Random().Next(1, 5),
                    AverageConsumption = new Random().Next(3, 20),
                },
                Engine = new CreateEngineDTO
                {
                    Name = "Default Engine",
                    FuelType = FuelType.Diesel,
                    Horsepower = new Random().Next(5, 500),
                    EngineCapacity = new Random().Next(500, 5000),
                },
                Body = new CreateBodyDTO
                {
                    DoorCount = new Random().Next(3, 5),
                    SeatCount = new Random().Next(3, 5),
                    ACType = ACType.Manual,
                    Color = "Black",
                    DrivetrainType = DrivetrainType.FWD,
                    BodyShape = BodyShape.Sedan
                }
            };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _logger.LogInformation("OnPostAsync called");

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                _logger.LogWarning("User is not authenticated");
                return Challenge();
            }

            if (!IsNewEngine && (SelectedEngineId == null || string.IsNullOrEmpty(SelectedEngineId)))
            {
                _logger.LogWarning("Engine selection is invalid");

                EngineList = (await _engineService.GetAllEnginesAsync()).Select(e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                }).ToList();

                ModelState.AddModelError(string.Empty, "Please select an engine.");
                return Page();
            }

            GeneralListing.Listing.UserId = user.Id;
            GeneralListing.Listing.CreationDate = DateTime.UtcNow;
            GeneralListing.Listing.IsSold = false;

            ModelState.ClearValidationState(nameof(GeneralListing));
            TryValidateModel(GeneralListing, nameof(GeneralListing));

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                foreach (var error in errors)
                {
                    _logger.LogError(error);
                }
                return Page();
            }

            try
            {
                _logger.LogInformation("Creating engine");
                if (IsNewEngine)
                {
                    var engineId = await _engineService.CreateEngineAsync(GeneralListing.Engine);
                    GeneralListing.Vehicle.EngineId = engineId;
                    _logger.LogInformation("Engine created with ID: {EngineId}", engineId);
                }
                else
                {
                    GeneralListing.Vehicle.EngineId = SelectedEngineId;

                    _logger.LogInformation("Engine selected with ID: {SelectedEngineId}", SelectedEngineId);
                }

                _logger.LogInformation("Creating body");
                var bodyId = await _bodyService.CreateBodyAsync(GeneralListing.Body);
                GeneralListing.Vehicle.BodyId = bodyId;
                _logger.LogInformation("Body created with ID: {BodyId}", bodyId);

                _logger.LogInformation("Engine ID set to Vehicle: {EngineId}", GeneralListing.Vehicle.EngineId);
                _logger.LogInformation("Body ID set to Vehicle: {BodyId}", GeneralListing.Vehicle.BodyId);

                _logger.LogInformation("Creating vehicle");
                var vehicle = await _vehicleService.CreateVehicleAsync(GeneralListing.Vehicle);
                GeneralListing.Listing.VehicleId = vehicle.Id;
                _logger.LogInformation("Vehicle created with ID: {VehicleId}", vehicle.Id);



                _logger.LogInformation("Creating listing");
                await _listingService.CreateListingAsync(GeneralListing.Listing);
                _logger.LogInformation("Listing created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating listing, vehicle, engine, or body.");
                throw;
            }

            return RedirectToPage("/Index");
        }

    }
}
