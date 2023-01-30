using System.Threading.Tasks;

namespace Ecommerce.Core.Repositories.Queries
{
    public interface IQueryRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}