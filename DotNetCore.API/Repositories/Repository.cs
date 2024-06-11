using DotNetCore.API.Data;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DotNetCore.API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly OnlineStoreDbContext _dbContext;
        internal DbSet<T> dbSet;
        public Repository(OnlineStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }

            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return await query.FirstOrDefaultAsync();
        }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, string? filterOn = null, 
            string? filterQuery = null, string? sortBy = null, bool isAscending = true)
        {
            IQueryable<T> query = dbSet;
            
            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = IncludeProperties(query, includeProperties);

            query = ApplyFiltering(query, filterOn, filterQuery);
            query = ApplySorting(query, sortBy, isAscending);

            return await query.ToListAsync();
        }


        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(Expression<Func<T, bool>> filter)
        {
            var entitiesToRemove = await dbSet.Where(filter).ToListAsync();
            dbSet.RemoveRange(entitiesToRemove);
            await _dbContext.SaveChangesAsync();
        }

        private IQueryable<T> IncludeProperties(IQueryable<T> query, string? includeProperties)
        {
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query;
        }

        private IQueryable<T> ApplyFiltering(IQueryable<T> query, string? filterOn, string? filterQuery)
        {
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, filterOn);
                var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
                var someValue = Expression.Constant(filterQuery, typeof(string));
                var containsExpression = Expression.Call(property, containsMethod, someValue);
                var lambda = Expression.Lambda<Func<T, bool>>(containsExpression, parameter);
                query = query.Where(lambda);
            }
            return query;
        }

        private IQueryable<T> ApplySorting(IQueryable<T> query, string? sortBy, bool isAscending)
        {
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                var parameter = Expression.Parameter(typeof(T), "x");
                var property = Expression.Property(parameter, sortBy);
                var lambda = Expression.Lambda(property, parameter);
                var methodName = isAscending ? "OrderBy" : "OrderByDescending";
                var method = typeof(Queryable).GetMethods().First(m => m.Name == methodName && m.GetParameters().Length == 2);
                var genericMethod = method.MakeGenericMethod(typeof(T), property.Type);
                query = (IQueryable<T>)genericMethod.Invoke(null, new object[] { query, lambda });
            }
            return query;
        }
    }
}
