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
    }
}
