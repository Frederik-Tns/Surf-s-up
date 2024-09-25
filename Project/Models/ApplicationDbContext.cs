using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Models;
public class ApplicationDbContext : IdentityDbContext<AppUser>
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Surfboard> Surfboards { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}