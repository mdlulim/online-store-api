using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface IImageRepository : IRepository<Image>
    {
        void Update(Image image);
    }
}

