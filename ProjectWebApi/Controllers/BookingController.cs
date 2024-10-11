using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApi.ApiModel;
using ProjectWebApi.Data;

namespace ProjectWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllBoards()
        {
            var surfboards = await _context.Surfboards.ToListAsync();
            return Ok(surfboards);
        }

    
        [HttpPost]
        public async Task<IActionResult> CreateBooking([FromBody] Booking booking)
        {
            if (booking == null)
            {
                return BadRequest("Booking object is null.");
            }

            if (ModelState.IsValid)
            {
                // Tilknyt surfboard til bookingen, hvis SurfboardId er angivet
                if (booking.SurfboardId.HasValue)
                {
                    var surfboard = await _context.Surfboards.FindAsync(booking.SurfboardId.Value);
                    if (surfboard == null)
                    {
                        return BadRequest($"Surfboard with ID {booking.SurfboardId.Value} not found.");
                    }
                    booking.Surfboard = surfboard;
                }

                // Gem booking i databasen
                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
               
                return Ok(new { message = "Booking created successfully", booking });
            }

           
            return BadRequest(ModelState);
        }







    }
}
