using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;

namespace Project.Controllers
{
    public class CartController : Controller
    {
        private readonly SurfboardService _surfboardService;

        public CartController(SurfboardService surfboardService)
        {
            _surfboardService = surfboardService;
        }

        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(string name)
        {
            // Fetch surfboards from the service
            var surfboards = await _surfboardService.GetAllBoards();
            var selectedBoard = surfboards.FirstOrDefault(s => s.Name == name);

            if (selectedBoard != null)
            {
                Cart cart = GetCart();
                cart.Surfboards.Add(selectedBoard);
                SaveCart(cart);
            }

            return RedirectToAction("Index", "Surfboard"); // Redirect back to the surfboard list in SurfboardController
        }

        public Cart GetCart()
        {
            var cart = HttpContext.Session.GetString("Cart");
            if (cart == null)
            {
                return new Cart();
            }

            return JsonConvert.DeserializeObject<Cart>(cart);
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetString("Cart", JsonConvert.SerializeObject(cart));
        }

        public int CartCount()
        {
            var cart = GetCart();
            return cart.Surfboards.Count();
        }
    }
}
