using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        //Dependency injection af database
        private ApplicationDbContext _applicationDbContext;
        private readonly SurfboardRepo _surfboardRepo;
        private AppUserRepo _appUserRepo;

        public IActionResult Index()
        {
            _applicationDbContext.Database.EnsureCreated();

            return View(Index);
        }

        [HttpPost]
        public IActionResult ConfirmBasket(string[] surfBoardIds)
        {
            _applicationDbContext.Database.EnsureCreated();
            Basket.TotalPrice = 0;

            if (LayoutModel.UserLogged.Length > 0)
            {
                AppUser userToAdd = _appUserRepo.GetUser(LayoutModel.UserLogged);

                Booking bookingToAdd = new Booking
                {
                    User = userToAdd,
                    Surfboards = new List<Surfboard>()
                };

                if (surfBoardIds.Length > 0)
                {
                    var surfboards = _surfboardRepo.GetSurfboardListByIds(surfBoardIds.Select(int.Parse).ToArray());
                    bookingToAdd.Surfboards.AddRange(surfboards);

                    foreach (var board in surfboards)
                    {
                        board.IsBooked = true;
                    }
                }

                _applicationDbContext.Bookings.Add(bookingToAdd);
                _applicationDbContext.SaveChanges();
                Basket.TotalPrice = 0;
            }

           

            return View("Index");
        }


        public HomeController(ApplicationDbContext applicationDbContext, SurfboardRepo surfboardRepo, AppUserRepo appUserRepo)
        {
            _applicationDbContext = applicationDbContext;
            _surfboardRepo = surfboardRepo;
            _appUserRepo = appUserRepo;
        }
    }
}
