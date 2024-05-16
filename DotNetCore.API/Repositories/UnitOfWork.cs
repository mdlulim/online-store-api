using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineStoreDbContext _dbContext;
        public IRegionRepository Region { get; private set; }
        public UnitOfWork(OnlineStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            Region = new RegionRepository(dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
