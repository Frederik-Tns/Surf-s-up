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
        public IActionResult Shortboards()
        {
            List<Surfboard> shortboards = surfboardRepo.GetSurfBoardsByType("Shortboards");
            return View(shortboards);
        }
        public IActionResult Funboards()
        {
            List<Surfboard> funboards = surfboardRepo.GetSurfBoardsByType("Funboards");
            return View(funboards);
        }

        public IActionResult Fishs()
        {
            List<Surfboard> fishs = surfboardRepo.GetSurfBoardsByType("Fishs");
            return View(fishs);
        }

        public IActionResult Longboards()
        {
            List<Surfboard> longboards = surfboardRepo.GetSurfBoardsByType("Longboards");
            return View(longboards);
        }

        public IActionResult SUPs()
        {
            List<Surfboard> sups = surfboardRepo.GetSurfBoardsByType("SUPs");
            return View(sups);
        }

       
    }
}
