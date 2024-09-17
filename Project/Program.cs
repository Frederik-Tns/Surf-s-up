using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.Models;
using Project.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure Entity Framework Core and your DbContext with the connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
//dependency injection
builder.Services.AddScoped<BasketService>();
builder.Services.AddScoped<SurfboardRepo>();

var app = builder.Build();

// Middleware for serving static files
app.UseStaticFiles();

// Configure routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
