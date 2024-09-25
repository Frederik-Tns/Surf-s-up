using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        //Dependency injection af database
        private ApplicationDbContext _applicationDbContext;
        private readonly SurfboardRepo _surfboardRepo;

        public IActionResult Index()
        {
            _applicationDbContext.Database.EnsureCreated();

            return View(Index);
        }

        [HttpPost]
        public IActionResult ConfirmBasket(string name, string email, string[] surfBoardIds)
        {
            _applicationDbContext.Database.EnsureCreated();
            Basket.TotalPrice = 0;

            User userToAdd = new User
            {
                Name = name,
                Email = email,

            };

            Booking bookingToAdd = new Booking
            {
                User = userToAdd,
                Surfboards = new List<Surfboard>()
            };

            if (surfBoardIds.Length > 0)
            {
                var surfboards = _surfboardRepo.GetSurfboardListByIds(surfBoardIds.Select(int.Parse).ToArray());
                bookingToAdd.Surfboards.AddRange(surfboards);
                
                foreach(var board in surfboards)
                {
                    board.IsBooked = true;
                }
            }

            _applicationDbContext.Bookings.Add(bookingToAdd);
            _applicationDbContext.SaveChanges();

            return View("Index");
        }


        public HomeController(ApplicationDbContext applicationDbContext, SurfboardRepo surfboardRepo)
        {
            _applicationDbContext = applicationDbContext;
            _surfboardRepo = surfboardRepo;
        }
    }
}
