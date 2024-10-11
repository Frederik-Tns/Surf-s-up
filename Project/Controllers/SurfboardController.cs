using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class SurfboardController : Controller
    {
        private readonly SurfboardService _surfboardService;

        public SurfboardController(SurfboardService surfboardService)
        {
            _surfboardService = surfboardService;
        }

        // GET: Surfboard/Index
        public async Task<IActionResult> Index()
        {
            // Fetch surfboards from the service
            var surfboards = await _surfboardService.GetAllBoards();

            if (surfboards == null)
            {
                return View(new List<Surfboard>()); // Return an empty list in case of error
            }

            return View(surfboards); // Pass the list of surfboards to the view
        }
    }
}
