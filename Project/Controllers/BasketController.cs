using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class BasketController : Controller
    {
        private SurfboardRepo repo = new SurfboardRepo();
        // Visning af kurvens indhold
        public IActionResult Index()
        {
            return View(Basket.RentedBoards);
        }




        [HttpPost]
        public IActionResult AddToBasket(int surfboardId)
        {
            var surfboard = repo.GetSurfBoardById(surfboardId);

            if (surfboard != null)
            {
                Basket.RentedBoards.Add(surfboard);
                GetTotalPrice();
            }

            return Ok(); // Returner succes status
        }



        private void GetTotalPrice()
        {
            Basket.TotalPrice = 0;  
            foreach (var item in Basket.RentedBoards)
            {
                Basket.TotalPrice += item.Price;
            }
        }
    }
}
