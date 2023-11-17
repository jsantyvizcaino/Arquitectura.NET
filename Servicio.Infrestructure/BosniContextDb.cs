using Microsoft.EntityFrameworkCore;
using Servicio.Domain.Contratos;
using Servicio.Domain.Entities;
using System.Reflection;

namespace Servicio.Infrestructure
{
    public class BosniContextDb : DbContext, IUnidadDeTrabajo
    {
        public BosniContextDb(DbContextOptions<BosniContextDb> opciones) : base(opciones)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public virtual DbSet<PbPlanBianual> PbPlanBianuals { get; set; } = null!;

        public async Task<int> AlmacenarEntidades(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
