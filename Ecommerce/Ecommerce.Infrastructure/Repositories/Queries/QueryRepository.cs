using Ecommerce.Core.Repositories.Queries;
using Ecommerce.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Infrastructure.Queries
{
    public class QueryRepository<T> : DbConnector, IQueryRepository<T> where T : class
    {
        public QueryRepository(IConfiguration configuration) : base(configuration)
        {
            
        }
    }
}