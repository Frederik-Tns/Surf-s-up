using Microsoft.AspNetCore.Mvc;
using SurfsUpWebApi.Models;

namespace SurfsUpWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurfboardController : ControllerBase
    {
        private List<Surfboard> _surfboards;
        [HttpGet]
        public IEnumerable<Surfboard> GetSurfBoards()
        {
            var surfboards = new List<Surfboard>();
            return surfboards;
        }

        [HttpGet("{id}")]
        public Surfboard GetById(int id)
        {   
            var surfboard = _surfboards.FirstOrDefault(s => s.SurfboardId == id);
            if (surfboard == null)
                return NotFound();
            return surfboard;
        }

        [HttpGet("{type}")]
        public Surfboard GetByType(Types type)
        {

        }

        [HttpPost]
        public string CreateSurfBoard()
        {
            return "Creating Surfboard";

        }
    }
}
