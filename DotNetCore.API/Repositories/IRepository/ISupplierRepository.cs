using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        void Update(Supplier supplier);
    }
}
