using DotNetCore.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCore.API.Data
{
    public class OnlineStoreDbContext : DbContext
    {
        // Creating a constructor
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options) : base(options)
        {
        }

        // DbSet is the property of the db class that represents the collection of entities in the database
        public DbSet<Region> Regions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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