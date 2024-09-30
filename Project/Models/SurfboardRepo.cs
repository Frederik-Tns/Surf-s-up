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
            Surfboards = new List<Surfboard>();
            LoadAllBoards();
        }


        private List<Surfboard> _surfboards;

        public List<Surfboard> Surfboards
        {
            get { return _surfboards; }
            set { _surfboards = value; }
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

        public void LoadAllBoards()
        {
            foreach(var surfboards in _context.Surfboards)
            {
                Surfboards.Add(surfboards);
            }
        }
    }

}
