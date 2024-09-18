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

        
        public IActionResult Index()
        {
            return View(Basket.BoardsInBasket);
        }

        
        [HttpPost]
        public IActionResult AddToBasket(int surfboardId, DateTime BookingStartDate, DateTime BookingEndDate, int quantity = 1)
        {
            
            _basketService.AddToBasket(surfboardId, quantity, BookingStartDate, BookingEndDate);


            var surfboard = _basketService.GetSurfBoardById(surfboardId);
            if (surfboard != null)
            {
                return RedirectToAction("SurfboardsByType", "Udlejning", new { type = surfboard.Type });
            }

            return RedirectToAction("Index", "Home");
        }

        
        [HttpPost]
        public IActionResult RemoveFromBasket(int surfboardId, DateTime BookingStartDate, DateTime BookingEndDate)
        {
            _basketService.RemoveFromBasket(surfboardId, BookingStartDate, BookingEndDate);
            return RedirectToAction("Index");
        }
    }
}

