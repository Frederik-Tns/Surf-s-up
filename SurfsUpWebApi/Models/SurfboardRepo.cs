using SurfsUpWebApi.Data;
namespace SurfsUpWebApi.Models
{
    public class SurfboardRepo
    {
        private readonly ApplicationDbContext _context;

        public SurfboardRepo(ApplicationDbContext context)
        {
            _context = context;
        }




    }
}
