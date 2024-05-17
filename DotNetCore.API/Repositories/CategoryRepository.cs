using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly OnlineStoreDbContext _dbContext; 
        public CategoryRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Category category)
        {
            _dbContext.Categories.Update(category);
        }
    }
}
