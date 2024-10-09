using Microsoft.EntityFrameworkCore;
using ProjectWebApi.ApiModel;

namespace ProjectWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Surfboard> Surfboards { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
