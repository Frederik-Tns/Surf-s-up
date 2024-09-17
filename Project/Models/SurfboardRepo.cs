using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace Project.Models
{
    public class SurfboardRepo
    {
        ApplicationDbContext _context;
        private SurfboardRepo _instance;

        public SurfboardRepo Instance
        {
            get { return _instance; }
            
            set 
            { 
                if (_instance == null)
                {
                    _instance = value;
                }
            }
        }

        private List<Surfboard> surfboards = new List<Surfboard>();

        


        public SurfboardRepo(ApplicationDbContext context)
        {
            _context = context;
            GetAllBoards();
        }
        public void GetAllBoards()
        {
            _context.Database.EnsureCreated();
            surfboards = _context.Surfboards.ToList();
        }
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
        

        
    }

}
