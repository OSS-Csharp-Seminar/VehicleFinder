using Microsoft.EntityFrameworkCore;
using VehicleFinder.Entities;

namespace VehicleFinder.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Listing>().HasOne(v => v.Vehicle).WithOne(l => l.Listing).HasForeignKey<Listing>(v => v.VehicleId);

            modelBuilder.Entity<User>().HasMany(u => u.Listings).WithOne(l => l.User).HasForeignKey(l => l.UserId);
        }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
