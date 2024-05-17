using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly OnlineStoreDbContext _dbContext;

        public ProductRepository(OnlineStoreDbContext dbContext): base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
        }
    }
}
