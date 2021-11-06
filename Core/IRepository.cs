using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using moviesApi.Core.Kernel;
using moviesApi.Persistence;

namespace moviesApi.Core
{
    // At the moment is just using the necessary methods for the exercise, but
    // if the app needs a functions for add, delete or update an entity
    // these methods can be added here.
    public interface IRepository<T> where T : Entity
    {
        /// <summary>
        /// Get the detail of an entity by id
        /// </summary>
        /// <param name="id">The id of entity</param>
        /// <returns>The entity</returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Get the elements of T with pagination
        /// </summary>
        /// <param name="query">The pagenumber and page size</param>
        /// <returns>The total entities and entities</returns>
        Task<QueryResult<T>> GetByPagingAsync(QueryParameters query);

        /// <summary>
        /// Search an entity by a filter and get the results with pagination
        /// </summary>
        /// <param name="predicate">The filters</param>
        /// <param name="query">The page number and page size</param>
        /// <returns>The total entities and entities</returns>
        Task<QueryResult<T>> SearchForAsync(Expression<Func<T, bool>> predicate, QueryParameters query);
    }
}