

namespace dab2_EfCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Chairman> Chairmans { get; set; }
    }
}
