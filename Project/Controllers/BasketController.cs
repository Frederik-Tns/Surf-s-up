using Microsoft.AspNetCore.Mvc;
using Project.Services;
using Project.Models;
using System;

namespace Project.Controllers
{
    public class BasketController : Controller
    {
        private readonly BasketService _basketService;

        public BasketController(BasketService basketService)
        {
            _basketService = basketService;
        }

        // Show the contents of the basket
        public IActionResult Index()
        {
            return View(Basket.BoardsInBasket);
        }

        

        // Handle the Add to Basket form submission
        [HttpPost]
        public IActionResult AddToBasket(int surfboardId, DateTime BookingStartDate, DateTime BookingEndDate, int quantity = 1)
        {
            // Delegate the Add to Basket logic to the service
            _basketService.AddToBasket(surfboardId, quantity, BookingStartDate, BookingEndDate);

            // Optionally, retrieve the surfboard to properly redirect based on type
            var surfboard = _basketService.GetSurfBoardById(surfboardId);
            if (surfboard != null)
            {
                return RedirectToAction("SurfboardsByType", "Udlejning", new { type = surfboard.Type });
            }

            return RedirectToAction("Index", "Home");
        }

        // Handle the Remove from Basket operation
        [HttpPost]
        public IActionResult RemoveFromBasket(int surfboardId, DateTime BookingStartDate, DateTime BookingEndDate)
        {
            _basketService.RemoveFromBasket(surfboardId, BookingStartDate, BookingEndDate);
            return RedirectToAction("Index");
        }
    }
}

