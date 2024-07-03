using Microsoft.AspNetCore.Mvc;
using VehicleFinder.Services;
using VehicleFinder.DTOs.ListingDTO;

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

        // GET: api/Listings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetListingDTO>>> GetListings()
        {
            var listings = await _listingService.GetListingsAsync();
            return Ok(listings);
        }

        // GET: api/Listings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetListingDTO>> GetListing(string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return NotFound();
            }
            var listing = await _listingService.GetListingByIdAsync(id);

            if (listing == null)
            {
                return NotFound();
            }

            return Ok(listing);
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

        // POST: api/Listings
        //[HttpPost]
        //public async Task<ActionResult<CreateListingDTO>> PostListing(CreateListingDTO listingDto)
        //{
        //    var createdListing = await _listingService.CreateListingAsync(listingDto);
        //    return Ok();
        //}

        //// PUT: api/Listings/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutListing(int id, CreateListingDTO listingDto)
        //{
        //    if (id != listingDto.Id)
        //    {
        //        return BadRequest();
        //    }

        //    var result = await _listingService.UpdateListingAsync(id, listingDto);
        //    if (!result)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();
        //}

        // DELETE: api/Listings/5
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
