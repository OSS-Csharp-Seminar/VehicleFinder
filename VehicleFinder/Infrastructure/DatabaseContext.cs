using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleFinder.Entities;


namespace VehicleFinder.Infrastructure
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureRoles(modelBuilder);

            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Listing>()
                .HasOne(v => v.Vehicle)
                .WithOne(l => l.Listing)
                .HasForeignKey<Listing>(v => v.VehicleId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Listings)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId);

            modelBuilder.Entity<Vehicle>().HasOne(b => b.Body).WithOne(v => v.Vehicle).HasForeignKey<Vehicle>(b => b.BodyId);

            modelBuilder.Entity<Vehicle>()
                .HasOne(e => e.Engine)
                .WithMany(v => v.Vehicles)
                .HasForeignKey(v => v.EngineId);
        }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Body> Bodies { get; set; }

        private void ConfigureRoles(ModelBuilder modelBuilder)
        {
            var userRole = new IdentityRole("USER");
            userRole.NormalizedName = "USER";

            var adminRole = new IdentityRole("ADMIN");
            adminRole.NormalizedName = "ADMIN";

            modelBuilder.Entity<IdentityRole>().HasData(userRole, adminRole);
        }
    }

}
