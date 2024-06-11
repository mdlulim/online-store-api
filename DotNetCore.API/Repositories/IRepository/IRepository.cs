using System.Linq.Expressions;

namespace DotNetCore.API.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - It a name of the class for example Regions
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter=null, string? includeProperties = null, string? filterOn = null, 
            string? filterQuery = null, string? sortBy = null, bool isAscending = true);
        Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked=false);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        Task RemoveRangeAsync(Expression<Func<T, bool>> filter);
    }
}
