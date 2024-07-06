using Microsoft.AspNetCore.Mvc;
using VehicleFinder.Services;

namespace VehicleFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListingsController : ControllerBase
    {
        private readonly IListingService _listingService;

        public ListingsController(IListingService listingService)
        {
            _listingService = listingService;
        }

        [HttpPost("MarkAsSold")]
        public async Task<IActionResult> MarkAsSold([FromBody] string id)
        {
            var result = await _listingService.MarkAsSoldAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest("Failed to mark as sold.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListing(string id)
        {
            var result = await _listingService.DeleteListingAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
