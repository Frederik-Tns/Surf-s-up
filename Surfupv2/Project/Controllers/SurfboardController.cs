using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.Models;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class SurfboardController : Controller
    {
      
        private readonly HttpClient _httpClient;
    

        public SurfboardController(HttpClient httpClient)
        {
            
            _httpClient = httpClient;
            
        }



        public async Task<IActionResult> Index() 
        {
            var surfboards = await GetAllBoards();
            return View(surfboards);
        }

        [HttpGet] // Henter alle boards til visning
        private async Task<List<Surfboard>> GetAllBoards()
        {
            var response = await _httpClient.GetAsync("https://localhost:7194/Booking");

            if (response.IsSuccessStatusCode)
            {
                var surfboards = await response.Content.ReadFromJsonAsync<List<Surfboard>>();
                return surfboards; // Returnér surfboards til Index
            }

            // Returnér en tom liste, hvis API-anmodningen fejler
            return new List<Surfboard>();
        }





        // Sender det valgte Surfboard's Id videre til viewet som et booking objekt
        public async Task<IActionResult> Book(int id) // bruges i Index Viewet
        {
         
            var surfboards = await GetAllBoards();
   
            var surfboard = surfboards.FirstOrDefault(sb => sb.Id == id);

            if (surfboard == null)
            {
                return NotFound();
            }

            // Opret en bookingmodel og tilføj surfboard objektet
            var booking = new Booking 
            { 
                Surfboard = surfboard, 
                SurfboardId = surfboard.Id 
            };

            return View(booking);
        }



        [HttpPost]
        public async Task<IActionResult> Create(Booking booking) // Api kald, og tilføjelse af dato'er
        {
            if (ModelState.IsValid)
            {
                // Hent surfboardet fra API i stedet for databasen
                var surfboards = await GetAllBoards();
                var surfboard = surfboards.FirstOrDefault(sb => sb.Id == booking.SurfboardId);

                if (surfboard != null)
                {
                    // Tildel surfboard-objektet til booking
                    booking.Surfboard = surfboard;
                }

                // Send booking-objektet til API'et
                var response = await _httpClient.PostAsJsonAsync("https://localhost:7194/Booking", booking);

                if (response.IsSuccessStatusCode)
                {
                    // Hvis API-anmodningen er succesfuld
                    return RedirectToAction("Index");
                }
            }

            return View(booking);
        }

    }
}
