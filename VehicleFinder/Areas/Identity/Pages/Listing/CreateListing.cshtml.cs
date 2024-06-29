using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using VehicleFinder.DTOs.General;
using VehicleFinder.Entities;
using VehicleFinder.Enums;
using VehicleFinder.Services;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Pages
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

        public IActionResult OnGet()
        {
            return Page();
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
                var engineId = await _engineService.CreateEngineAsync(GeneralListing.Engine);
                GeneralListing.Vehicle.EngineId = engineId;
                _logger.LogInformation("Engine created with ID: {EngineId}", engineId);

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

        public IActionResult OnPostPopulateAsync()
        {
            // Populate with random values
            PopulateWithRandomValues();

            // Return to the same page
            return Page();
        }

        private void PopulateWithRandomValues()
        {
            // Example: Generate random values
            var random = new Random();
            GeneralListing.Listing.Title = "Random Title " + random.Next(1, 1000);
            GeneralListing.Listing.Description = "Random Description " + random.Next(1, 1000);
            GeneralListing.Listing.Price = random.Next(1000, 10000);
            GeneralListing.Listing.IsSold = random.Next(0, 2) == 1;

            GeneralListing.Vehicle.Brand = "Random Brand " + random.Next(1, 1000);
            GeneralListing.Vehicle.Model = "Random Model " + random.Next(1, 1000);
            GeneralListing.Vehicle.ManufacturingYear = random.Next(1990, 2023);

            string dateStr = "1.1.2024";
            DateOnly registrationDate;

            if (DateOnly.TryParseExact(dateStr, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out registrationDate))
            {
                GeneralListing.Vehicle.RegistrationUntil = registrationDate;
            }
            GeneralListing.Vehicle.Kilometers = random.Next(0, 200000);
            GeneralListing.Vehicle.NumberOfPreviousOwners = random.Next(0, 5);
            GeneralListing.Vehicle.ShifterType = (ShifterType)random.Next(Enum.GetValues(typeof(ShifterType)).Length);
            GeneralListing.Vehicle.GearCount = random.Next(4, 10);
            GeneralListing.Vehicle.AverageConsumption = 1000;

            GeneralListing.Engine.Name = "Random Engine " + random.Next(1, 1000);
            GeneralListing.Engine.FuelType = FuelType.Gasoline;
            GeneralListing.Engine.Horsepower = random.Next(100, 500);
            GeneralListing.Body.DrivetrainType = DrivetrainType.RWD;
            GeneralListing.Engine.EngineCapacity = 1000;

            GeneralListing.Body.DoorCount = random.Next(2, 5);
            GeneralListing.Body.SeatCount = random.Next(2, 7);
            GeneralListing.Body.ACType = (ACType)random.Next(Enum.GetValues(typeof(ACType)).Length);
            GeneralListing.Body.Color = "Random Color " + random.Next(1, 1000);
            GeneralListing.Body.BodyShape = (BodyShape)random.Next(Enum.GetValues(typeof(BodyShape)).Length);
        }
    }
}
