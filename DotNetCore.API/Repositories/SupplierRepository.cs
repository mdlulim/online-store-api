using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private readonly OnlineStoreDbContext _dbContext; 
        public SupplierRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Supplier supplier)
        {
            _dbContext.Suppiers.Update(supplier);
        }
    }
}
