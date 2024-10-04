using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Surf_s_up.Models;

namespace Surf_s_up.Controllers
{
    public class SurfboardController : Controller
    {
        private readonly HttpClient _httpClient;


        public SurfboardController(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBoards()
        {
            var response = await _httpClient.GetAsync("https://localhost:7041/api/Surfboard");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                var surfboardData = JsonConvert.DeserializeObject<List<Surfboard>>(jsonResponse);
                return View(surfboardData);

            }
            return View();
        }
    }
}
