using Newtonsoft.Json;
using Project.Models;

public class SurfboardService
{
    private readonly HttpClient _httpClient;

    public SurfboardService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Surfboard>> GetAllBoards()
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
}
