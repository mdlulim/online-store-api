using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.API.Data
{
    public class AuthOnlineStoreDbContext : IdentityDbContext
    {
        public AuthOnlineStoreDbContext(DbContextOptions<AuthOnlineStoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = "750e7ce2-3675-41bb-9887-b687654d3e5e",
                    ConcurrencyStamp = "750e7ce2-3675-41bb-9887-b687654d3e5e",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                },
                new IdentityRole
                {
                    Id = "8a82e768-3f75-4e30-83c5-d53f79880d4f",
                    ConcurrencyStamp = "8a82e768-3f75-4e30-83c5-d53f79880d4f",
                    Name = "Customer",
                    NormalizedName = "Customer".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
