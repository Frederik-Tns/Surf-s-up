using Microsoft.AspNetCore.Mvc;
using SurfsUpWebApi.Data;
using SurfsUpWebApi.Models;
using System.Security.Cryptography.X509Certificates;

namespace SurfsUpWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurfboardController : ControllerBase
    {

        private ApplicationDbContext _context;


        public SurfboardController(ApplicationDbContext context)
        {
            _context = context;


        }

        private List<Surfboard> _surfboards;

        public List<Surfboard> Surfboards
        {
            get { return _surfboards; }
            set { _surfboards = value; }
        }


        [HttpGet]
        public IEnumerable<Surfboard> GetAllSurfBoards()
        {
            return _context.Surfboards;

        }

        [HttpGet("{id}")]
        public Surfboard GetSurfboardById(int id)
        {
            var surfboard = _context.Surfboards.FirstOrDefault(s => s.SurfboardId == id);

            return surfboard;
        }

        [HttpGet("type/{type}")]
        public List<Surfboard> GetSurfboardByType(string type)
        {
            List<Surfboard> SurfboardsByType = new List<Surfboard>();  
            foreach (var surfboard in _context.Surfboards) 
            { if (surfboard.Type == type) SurfboardsByType.Add(surfboard); }

        return SurfboardsByType;
            
        }

        [HttpPost]
        public string CreateSurfBoard()
        {
            return "Creating Surfboard";

        }
    }
}
