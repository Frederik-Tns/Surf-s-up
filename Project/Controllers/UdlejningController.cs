using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class UdlejningController : Controller
    {
        private SurfboardRepo surfboardRepo;

        public UdlejningController() 
        {
            surfboardRepo = new SurfboardRepo();
        }
        public IActionResult SurfboardsByType(string type)
        {
            var validTypes = new List<string> { "Shortboards", "Funboards", "Fishs", "SUPs", "Longboards" };

            if (string.IsNullOrWhiteSpace(type) || !validTypes.Contains(type))
            {
                return NotFound("Invalid surfboard type.");
            }


            List<Surfboard> surfboards = surfboardRepo.GetSurfBoardsByType(type);

            ViewBag.SurfboardType = type;

            return View(surfboards);
        }

    }
}
