using Microsoft.EntityFrameworkCore;
using Project.Models;
namespace Project.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Surfboard> Surfboards { get; set; }  // Example entity


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Additional configurations here
    }
}