using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VehicleFinder.Entities;
using VehicleFinder.Enums;


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

            SeedUsers(modelBuilder);

            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Listing>()
                            .HasOne(l => l.Vehicle)
                            .WithOne() // No navigation property on the other side
                            .HasForeignKey<Listing>(l => l.VehicleId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Listings)
                .WithOne()
                .HasForeignKey(l => l.UserId);

            modelBuilder.Entity<Vehicle>().HasOne(b => b.Body).WithOne().HasForeignKey<Vehicle>(b => b.BodyId);

            modelBuilder.Entity<Vehicle>()
                .Property(v => v.ShifterType)
                .HasConversion(
                    v => v.ToString(),
                    v => (ShifterType)Enum.Parse(typeof(ShifterType), v));

            modelBuilder.Entity<Body>()
                .Property(b => b.DrivetrainType)
                .HasConversion(
                    b => b.ToString(),
                    b => (DrivetrainType)Enum.Parse(typeof(DrivetrainType), b));

            modelBuilder.Entity<Body>()
                .Property(b => b.ACType)
                .HasConversion(
                    b => b.ToString(),
                    b => (ACType)Enum.Parse(typeof(ACType), b));

            modelBuilder.Entity<Body>()
                .Property(b => b.BodyShape)
                .HasConversion(
                    b => b.ToString(),
                    b => (BodyShape)Enum.Parse(typeof(BodyShape), b));

            modelBuilder.Entity<Engine>()
                .Property(e => e.FuelType)
                .HasConversion(
                    e => e.ToString(),
                    e => (FuelType)Enum.Parse(typeof(FuelType), e));
        }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Body> Bodies { get; set; }

        public IdentityRole userRole;
        public IdentityRole adminRole;

        private void ConfigureRoles(ModelBuilder modelBuilder)
        {
            userRole = new IdentityRole("USER");
            userRole.NormalizedName = "USER";

            adminRole = new IdentityRole("ADMIN");
            adminRole.NormalizedName = "ADMIN";

            modelBuilder.Entity<IdentityRole>().HasData(userRole, adminRole);
        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<User>();

            // User with 'USER' role
            var normalUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "user@user",
                NormalizedUserName = "USER@USER",
                Email = "user@user",
                NormalizedEmail = "USER@USER",
                EmailConfirmed = false,
                PhoneNumber = "1234567890",
                PhoneNumberConfirmed = true,
                FirstName = "user",
                LastName = "user",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            normalUser.PasswordHash = hasher.HashPassword(normalUser, "aA!123123");

            // User with 'ADMIN' role
            var adminUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "admin@eadmin",
                NormalizedUserName = "ADMIN@ADMIN",
                Email = "admin@eadmin",
                NormalizedEmail = "ADMIN@ADMIN",
                EmailConfirmed = false,
                PhoneNumber = "1234567890",
                PhoneNumberConfirmed = true,
                FirstName = "admin",
                LastName = "admin",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "aA!123123");

            modelBuilder.Entity<User>().HasData(normalUser, adminUser);

            // Assign roles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = normalUser.Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = adminRole.Id,
                    UserId = adminUser.Id
                }
            );
        }

        public void ExecuteSqlScript(string sqlScriptFilePath)
        {
            string sqlScript = File.ReadAllText(sqlScriptFilePath);

            Database.ExecuteSqlRaw(sqlScript);
        }

    }

}
