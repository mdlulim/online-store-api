using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);

    }
}
