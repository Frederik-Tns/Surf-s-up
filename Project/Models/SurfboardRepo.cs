using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace Project.Models
{
    public class SurfboardRepo
    {
        private readonly ApplicationDbContext _context; // Use readonly for injected dependencies

        // Public constructor for dependency injection
        public SurfboardRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        // Methods that interact with the database
        public List<Surfboard> GetSurfBoardsByType(string type)
        {
            return _context.Surfboards.Where(s => s.Type == type).ToList();
        }

        public Surfboard GetSurfBoardById(int id)
        {
            return _context.Surfboards.Find(id);
        }

        public bool AllBoardsBooked(string name)
        {
            return !_context.Surfboards.Any(s => s.Name == name && !s.IsBooked);
        }

        public List<Surfboard> GetSurfboardListByIds(int[] surfboardIds)
        {
            return _context.Surfboards.Where(s => surfboardIds.Contains(s.SurfboardId)).ToList();
        }
    }

}
