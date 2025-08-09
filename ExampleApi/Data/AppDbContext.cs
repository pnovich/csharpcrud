using Microsoft.EntityFrameworkCore;
using MyApp.DTOs;

namespace MyApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<ExampleDto> Examples { get; set; } = null!;
    }
}