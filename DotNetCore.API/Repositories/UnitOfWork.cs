using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineStoreDbContext _dbContext;
        public IRegionRepository Region { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISupplierRepository Supplier { get; private set; }
        public IImageRepository Image { get; private set; }
        public UnitOfWork(OnlineStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            Region = new RegionRepository(dbContext);
            Category = new CategoryRepository(dbContext);
            Product = new ProductRepository(dbContext);
            Supplier = new SupplierRepository(dbContext);
            Image = new ImageRepository(dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
