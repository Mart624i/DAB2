using dab2_EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace dab2_EfCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Chairman> Chairmen { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Society> Societies { get; set; }
    }
}
