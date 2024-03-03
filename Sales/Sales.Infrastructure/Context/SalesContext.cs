using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entitites;
using SalesOnline.Domain.Entities;

namespace Sales.Infrastructure.Context
{
    public partial class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {

        }
    }

    public partial class SalesContext
    {
        #region DbSet
        public DbSet<Rol> rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        #endregion
    }
}
