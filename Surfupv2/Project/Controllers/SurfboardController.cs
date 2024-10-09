using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;

namespace Project.Controllers
{
    public class SurfboardController : Controller
    {
        private readonly HttpClient _httpClient;

        public SurfboardController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET: Surfboard/Index
        public async Task<IActionResult> Index()
        {
            // Fetch surfboards from the API
            var surfboards = await GetAllBoards();

            if (surfboards == null)
            {
                return View(new List<Surfboard>()); // Return an empty list in case of error
            }

            return View(surfboards); // Pass the list of surfboards to the view
        }

        // This method fetches surfboards from the Web API
        [HttpGet]
        private async Task<List<Surfboard>> GetAllBoards()
        {
            var response = await _httpClient.GetAsync("https://localhost:7194/api/SurfboardApi"); // Call your API

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var surfboards = JsonConvert.DeserializeObject<List<Surfboard>>(jsonResponse);
                return surfboards;
            }

            return null; // Return null if the API request fails
        }
        public IActionResult Cart()
        {
            Cart cart = GetCart();  // Retrieve the cart from the session or another storage
            return View(cart);  // Pass the cart to the view
        }

        [HttpPost]
        public IActionResult AddToCart(string name)
        {
            var surfboards = GetAllBoards().Result;
            var selectedBoard = surfboards.FirstOrDefault(s => s.Name == name);

            if (selectedBoard != null)
            {
                Cart cart = GetCart();
                cart.AddSurfboard(selectedBoard);
                SaveCart(cart);
            }

            return RedirectToAction("Index"); // Redirect back to the surfboard list
        }
        private Cart GetCart()
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
    }
}
