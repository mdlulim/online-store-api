namespace DotNetCore.API.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        IRegionRepository Region { get; }
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        void Save();
    }
}
