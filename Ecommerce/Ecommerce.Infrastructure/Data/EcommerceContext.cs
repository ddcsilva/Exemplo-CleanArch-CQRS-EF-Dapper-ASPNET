using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Data
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}