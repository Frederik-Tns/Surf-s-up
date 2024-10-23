using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
