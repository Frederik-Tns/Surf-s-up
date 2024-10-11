using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectWebApi.ApiModel;
using ProjectWebApi.Data;

namespace ProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfboardApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SurfboardApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/surfboard
        [HttpGet]
        public async Task<IActionResult> GetAllBoards()
        {
            var surfboards = await _context.Surfboards.ToListAsync();
            return Ok(surfboards);
        }

        // GET: api/surfboard/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Surfboard>> GetSurfboard(int id)
        {
            var surfboard = await _context.Surfboards.FindAsync(id);

            if (surfboard == null)
            {
                return NotFound();
            }

            return Ok(surfboard);
        }
    }
}
