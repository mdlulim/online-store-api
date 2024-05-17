using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
