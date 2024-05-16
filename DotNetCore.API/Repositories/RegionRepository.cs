using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.API.Repositories
{
    public class RegionRepository: Repository<Region>, IRegionRepository
    {
        private OnlineStoreDbContext _dbContext;

        public RegionRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
           _dbContext = dbContext;
        }

        public void Update(Region region)
        {
            _dbContext.Regions.Update(region);
        }
    }
}
