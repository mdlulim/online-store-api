using DotNetCore.API.Data;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Repositories.IRepository;

namespace DotNetCore.API.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private readonly OnlineStoreDbContext _dbContext;
        public ImageRepository(OnlineStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void Update(Image image)
        {
            _dbContext.Images.Update(image);
        }
    }
}
