using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.Core.Entities;

namespace Ecommerce.Core.Repositories.Queries
{
    public interface ICustomerQueryRepository : IQueryRepository<Cliente>
    {
        // Operações personalizadas que não são genéricas
        Task<IReadOnlyList<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(Guid id);
        Task<Cliente> GetCustomerByEmail(string email);
    }
}