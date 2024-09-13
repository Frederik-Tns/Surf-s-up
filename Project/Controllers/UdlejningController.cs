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
            List<Surfboard> shortboards = surfboardRepo.GetSurfBoardsByType("Shortboard");
            return View(shortboards);
        }
        public IActionResult Funboards()
        {
            return View();
        }
    }
}
