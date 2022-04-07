using dab2_EfCore.Models;
using Microsoft.EntityFrameworkCore;

namespace dab2_EfCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Chairman>? Chairmen { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<Member>? Members { get; set; }
        public DbSet<Municipality>? Municipalities { get; set; }
        public DbSet<Room>? Rooms { get; set; }
        public DbSet<Society>? Societies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Society>()
                .HasOne(b => b.Chairman)
                .WithOne(i => i.Society)
                .HasForeignKey<Chairman>(b => b.Cvr_number);

            modelBuilder.Entity<Municipality>(entity => {
                
                entity.HasData(new Municipality
                {
                    Zipcode = 8000,
                    Name = "Aarhus",
                    AccessKey = 1111
                });

                entity.HasData(new Municipality
                {
                    Zipcode = 7700,
                    Name = "Thisted",
                    AccessKey = 2222
                });
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasData(new Location
                {
                    Address = "Denførstevej",
                    Bathroom = 1,
                    Zipcode = 8000
                });

                entity.HasData(new Location
                {
                    Address = "Denandenvej",
                    Bathroom = 2,
                    Zipcode = 7700
                });
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasData(new Room
                {
                    RoomNumber = 1,
                    Capacity = 100,
                    Address = "Denførstevej"
                });

                entity.HasData(new Room
                {
                    RoomNumber = 2,
                    Capacity = 200,
                    Address = "Denandenvej"
                });
            });

            modelBuilder.Entity<Society>(entity =>
            {
                entity.HasData(new Society
                {
                    Cvr_number = 1,
                    Zipcode = 8000,
                    Activity = "Fodbold"
                });

                entity.HasData(new Society
                {
                    Cvr_number = 2,
                    Zipcode = 7700,
                    Activity = "Håndbold"
                });
            });

            modelBuilder.Entity<Chairman>(entity =>
            {
                entity.HasData(new Chairman
                {
                    Cvr_number = 1,
                    Member_id = 1,
                    Name = "Martin",
                    Cpr_number = 1111,
                    Address = "Chairmanvejnummeret"
                });

                entity.HasData(new Chairman
                {
                    Cvr_number = 2,
                    Member_id = 2,
                    Name = "Jens",
                    Cpr_number = 2222,
                    Address = "Chairmanvejnummerto"
                });
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasData(new Member
                {
                    Member_id = 1,
                    Name = "Jesper",
                    Cvr_number = 1
                });

                entity.HasData(new Member
                {
                    Member_id = 2,
                    Name = "Carsten",
                    Cvr_number = 2
                });
            });
        }
    }
}
