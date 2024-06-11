using DotNetCore.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.API.Data
{
    public class OnlineStoreDbContext: DbContext
    {
        //creating a constructor
        public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options): base(options) 
        {

        }

        //DbSet is the proparty of db class that represent the collection of entities in the database
        public DbSet<Region> Regions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppiers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                    new Region { Id = Guid.NewGuid(), Name = "Gauteng", Code = "GP", Description = "Gauteng Province", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "KwaZulu-Natal", Code = "GP", Description = "KwaZulu-Natal", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Eastern Cape", Code = "EC", Description = "Eastern Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Free State", Code = "FS", Description = "Free State", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Limpopo", Code = "LP", Description = "Limpopo", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Mpumalanga", Code = "MP", Description = "Mpumalanga", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "North West", Code = "NW", Description = "North West", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Northern Cape", Code = "NC", Description = "Northern Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                    new Region { Id = Guid.NewGuid(), Name = "Western Cape", Code = "WC", Description = "Western Cape", CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
                );

            modelBuilder.Entity<Supplier>().HasData(
                 new Supplier
                 {
                     Id = Guid.NewGuid(),
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
