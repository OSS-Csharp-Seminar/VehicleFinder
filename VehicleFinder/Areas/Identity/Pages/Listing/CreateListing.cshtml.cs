using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using VehicleFinder.DTOs.General;
using VehicleFinder.Entities;
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
    }
}
