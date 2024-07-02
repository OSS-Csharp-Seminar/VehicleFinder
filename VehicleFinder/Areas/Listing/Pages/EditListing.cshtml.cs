using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VehicleFinder.DTOs.BodyDTO;
using VehicleFinder.DTOs.EngineDTO;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Services;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Areas.Listing.Pages
{
    public class EditListingModel : PageModel
    {
        private readonly IListingService _listingService;
        private readonly IVehicleService _vehicleService;
        private readonly IEngineService _engineService;
        private readonly IBodyService _bodyService;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<EditListingModel> _logger;

        public EditListingModel(
            IListingService listingService,
            IVehicleService vehicleService,
            IEngineService engineService,
            IBodyService bodyService,
            UserManager<User> userManager,
            ILogger<EditListingModel> logger)
        {
            _listingService = listingService;
            _vehicleService = vehicleService;
            _engineService = engineService;
            _bodyService = bodyService;
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public UpdateGeneralListingDTO UpdateGeneralListing { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var listing = await _listingService.GetGeneralListingByIdAsync(id);
            if (listing == null)
            {
                return NotFound();
            }

            var vehicle = await _vehicleService.GetVehicleByIdAsync(listing.Vehicle.Id);
            var body = await _bodyService.GetBodyByIdAsync(vehicle.BodyId);
            var engine = await _engineService.GetEngineByIdAsync(vehicle.EngineId);

            UpdateGeneralListing = new UpdateGeneralListingDTO
            {
                Listing = new UpdateListingDTO
                {
                    Id = listing.Listing.Id,
                    Title = listing.Listing.Title,
                    Description = listing.Listing.Description,
                    Price = listing.Listing.Price,
                    CreationDate = listing.Listing.CreationDate,
                    IsSold = listing.Listing.IsSold,
                    UserId = listing.Listing.UserId,
                },
                Vehicle = new UpdateVehicleDTO
                {
                    Id = vehicle.Id,
                    Brand = vehicle.Brand,
                    Model = vehicle.Model,
                    ManufacturingYear = vehicle.ManufacturingYear,
                    RegistrationUntil = vehicle.RegistrationUntil,
                    Kilometers = vehicle.Kilometers,
                    NumberOfPreviousOwners = vehicle.NumberOfPreviousOwners,
                    ShifterType = vehicle.ShifterType,
                    GearCount = vehicle.GearCount,
                    AverageConsumption = vehicle.AverageConsumption,
                    EngineId = vehicle.EngineId,
                    BodyId = vehicle.BodyId,
                    Engine = new UpdateEngineDTO
                    {
                        Id = engine.Id,
                        Name = engine.Name,
                        FuelType = engine.FuelType,
                        Horsepower = engine.Horsepower,
                        EngineCapacity = engine.EngineCapacity
                    },
                    Body = new UpdateBodyDTO
                    {
                        Id = body.Id,
                        DoorCount = body.DoorCount,
                        SeatCount = body.SeatCount,
                        ACType = body.ACType,
                        Color = body.Color,
                        DrivetrainType = body.DrivetrainType,
                        BodyShape = body.BodyShape
                    }
                },
                Engine = new UpdateEngineDTO
                {
                    Id = engine.Id,
                    Name = engine.Name,
                    FuelType = engine.FuelType,
                    Horsepower = engine.Horsepower,
                    EngineCapacity = engine.EngineCapacity
                },
                Body = new UpdateBodyDTO
                {
                    Id = body.Id,
                    DoorCount = body.DoorCount,
                    SeatCount = body.SeatCount,
                    ACType = body.ACType,
                    Color = body.Color,
                    DrivetrainType = body.DrivetrainType,
                    BodyShape = body.BodyShape
                }
            };

            UpdateGeneralListing.Vehicle.Engine = UpdateGeneralListing.Engine;
            UpdateGeneralListing.Vehicle.Body = UpdateGeneralListing.Body;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Challenge();
            }

            UpdateGeneralListing.Listing.UserId = user.Id;

            if (!ModelState.IsValid)
            {
                // Log the validation errors
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    foreach (var error in value.Errors)
                    {
                        _logger.LogError($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
                    }
                }
                return Page();
            }

            try
            {
                await _listingService.UpdateListingAsync(UpdateGeneralListing);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating listing.");
                ModelState.AddModelError(string.Empty, "An error occurred while updating the listing.");
                return Page();
            }

            return RedirectToPage("/Index");
        }
    }
}
