using System.Collections.Generic;

namespace moviesApi.Persistence
{
    public class QueryResult<T> where T : class
    {
        public int TotalEntities { get; set; }
        public IEnumerable<T> Entities { get; set; }
    }
}