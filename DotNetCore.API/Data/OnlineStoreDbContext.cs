using DotNetCore.API.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DotNetCore.API.Data
{
    public class OnlineStoreDbContext : IdentityDbContext
    {
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options) : base(options)
        {

        }

        // DbSet is the property of the db class that represents the collection of entities in the database
        public DbSet<Region> Regions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var roles = new List<IdentityRole>
            {
                
            };

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "750e7ce2-3675-41bb-9887-b687654d3e5e", ConcurrencyStamp = "750e7ce2-3675-41bb-9887-b687654d3e5e", Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new IdentityRole { Id = "8a82e768-3f75-4e30-83c5-d53f79880d4f", ConcurrencyStamp = "8a82e768-3f75-4e30-83c5-d53f79880d4f", Name = "Employee", NormalizedName = "Employee".ToUpper() },
                new IdentityRole { Id = "8a9d5120-54e8-46ee-8ed8-9e72712e6920", ConcurrencyStamp = "8a9d5120-54e8-46ee-8ed8-9e72712e6920", Name = "Customer", NormalizedName = "Customer".ToUpper() }
            );

            modelBuilder.Entity<Region>().HasData(
                new Region { Id = Guid.Parse("f3604540-6c24-4959-ae2e-8047b7d9f1fb"), Name = "Gauteng", Code = "GP", Description = "Gauteng Province", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b0"), Name = "KwaZulu-Natal", Code = "KZN", Description = "KwaZulu-Natal", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b1"), Name = "Eastern Cape", Code = "EC", Description = "Eastern Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b2"), Name = "Free State", Code = "FS", Description = "Free State", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b3"), Name = "Limpopo", Code = "LP", Description = "Limpopo", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b4"), Name = "Mpumalanga", Code = "MP", Description = "Mpumalanga", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b5"), Name = "North West", Code = "NW", Description = "North West", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b6"), Name = "Northern Cape", Code = "NC", Description = "Northern Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Region { Id = Guid.Parse("a083a8da-d9a1-4c2d-85e2-f6d1234a56b7"), Name = "Western Cape", Code = "WC", Description = "Western Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = Guid.Parse("a3a5f2d4-8e92-46c8-9232-f8de57f2c2af"),
                    VendorCode = "TPC",
                    Name = "The Prepaid Company",
                    IsActive = 1,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow
                }
            );
        }
    }
}
