namespace DotNetCore.API.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        IRegionRepository Region { get; }
        void Save();
    }
}
