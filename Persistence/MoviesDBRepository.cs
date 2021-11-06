using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesApi.Core;
using moviesApi.Core.Kernel;

namespace moviesApi.Persistence
{
    // TODO: Catch in a right way the exceptions, add a logs pattern for manage errors
    public class MoviesDBRepository<T> : IRepository<T> where T : Entity
    {
        private readonly MoviesDBContext _context;
        private DbSet<T> _entities;

        public MoviesDBRepository(MoviesDBContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            try
            {
                return await _entities.SingleOrDefaultAsync(s => s.Id == id);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<QueryResult<T>> GetByPagingAsync(QueryParameters query)
        {
            try
            {
                var elements = await _entities.Skip((query.Page - 1) * query.PageSize)
                                              .Take(query.PageSize)
                                              .ToListAsync();

                var totalElements = await _entities.CountAsync();

                return new QueryResult<T>()
                {
                    Entities = elements,
                    TotalEntities = totalElements
                };
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<QueryResult<T>> SearchForAsync(Expression<Func<T, bool>> predicate, QueryParameters query)
        {
            try
            {
                var elements = new List<T>();
                var totalElements = 0;

                if (predicate == null)
                {
                    elements = await _entities.Skip((query.Page - 1) * query.PageSize)
                                              .Take(query.PageSize)
                                              .ToListAsync();

                    totalElements = await _entities.CountAsync();

                }
                else
                {
                    elements = await _entities.Where(predicate)
                                              .Skip((query.Page - 1) * query.PageSize)
                                              .Take(query.PageSize)
                                              .ToListAsync();

                    totalElements = await _entities.Where(predicate)
                                                   .CountAsync();
                }

                return await Task.FromResult<QueryResult<T>>(
                    new QueryResult<T>()
                    {
                        Entities = elements,
                        TotalEntities = totalElements
                    }
                );

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}