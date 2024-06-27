using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using VehicleFinder.DTOs.ListingDTO;
using VehicleFinder.DTOs.VehicleDTO;
using VehicleFinder.Entities;
using VehicleFinder.Services;
using VehicleFinder.Services.Interface;

namespace VehicleFinder.Pages
{
    public class CreateListingModel : PageModel
    {
        private readonly IListingService _listingService;
        private readonly IVehicleService _vehicleService;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<CreateListingModel> _logger;

        public CreateListingModel(IListingService listingService, IVehicleService vehicleService, UserManager<User> userManager, ILogger<CreateListingModel> logger)
        {
            _listingService = listingService;
            _vehicleService = vehicleService;
            _userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public CreateListingDTO Listing { get; set; }

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

            Listing.UserId = user.Id;
            Listing.CreationDate = DateTime.UtcNow;

            ModelState.ClearValidationState(nameof(Listing));
            TryValidateModel(Listing, nameof(Listing));

            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
                foreach (var error in errors)
                {
                    System.Diagnostics.Debug.WriteLine(error);
                }
                return Page();
            }

            _logger.LogInformation("Creating vehicle for listing");

            var vehicleDto = new CreateVehicleDTO
            {
                Brand = Listing.Vehicle.Brand,
                Model = Listing.Vehicle.Model,
                ManufacturingYear = Listing.Vehicle.ManufacturingYear,
                RegistrationUntil = Listing.Vehicle.RegistrationUntil,
                Kilometers = Listing.Vehicle.Kilometers,
                NumberOfPreviousOwners = Listing.Vehicle.NumberOfPreviousOwners
            };

            var createdVehicle = await _vehicleService.CreateVehicleAsync(vehicleDto);

            _logger.LogInformation("Vehicle created with ID: {VehicleId}", createdVehicle.Id);

            _logger.LogInformation("Creating listing");
            await _listingService.CreateListingAsync(Listing, createdVehicle);

            _logger.LogInformation("Listing created successfully");
            return RedirectToPage("/Index");
        }
    }
}
