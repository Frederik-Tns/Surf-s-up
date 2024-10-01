using Microsoft.EntityFrameworkCore;
using SurfsUpWebApi.Models;
namespace SurfsUpWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Surfboard> Surfboards { get; set; }

       
    }
}
