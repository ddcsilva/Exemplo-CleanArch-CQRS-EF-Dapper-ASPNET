using Ecommerce.Core.Entities;
using Ecommerce.Core.Repositories.Commands;
using Ecommerce.Infrastructure.Data;

namespace Ecommerce.Infrastructure.Repositories.Command
{

    public class ClienteCommandRepository : CommandRepository<Cliente>, IClienteCommandRepository
    {
        public ClienteCommandRepository(EcommerceContext context) : base(context)
        {

        }
    }
}