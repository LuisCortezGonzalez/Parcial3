using Microsoft.EntityFrameworkCore;
using Parcial3.Entidades;

namespace Parcial3
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

    }
}
