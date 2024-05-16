using DotNetCore.API.Models.Domain;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface IRegionRepository : IRepository<Region>
    {
        void Update(Region region);
    }
}
