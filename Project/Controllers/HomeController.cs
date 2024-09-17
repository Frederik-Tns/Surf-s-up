using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        //Dependency injection af database
        private ApplicationDbContext _applicationDbContext;
        public IActionResult Index()
        {
            _applicationDbContext.Database.EnsureCreated();
            _applicationDbContext.Surfboards.Take(10); //returnere et hvis antal boards(så der ikke bliver vist alle boards på en gang)
            return View(Index);
        }
        public HomeController(ApplicationDbContext applicationDbContext) 
        {
            _applicationDbContext = applicationDbContext;
        }
    }
}
