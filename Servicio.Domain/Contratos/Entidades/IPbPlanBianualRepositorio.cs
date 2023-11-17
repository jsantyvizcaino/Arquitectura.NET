using Servicio.Domain.Entities;

namespace Servicio.Domain.Contratos.Entidades
{
    public interface IPbPlanBianualRepositorio : IRepositorio<PbPlanBianual, int>, IEntidadSqlRepositorio<PbPlanBianual, int>
    {
        IQueryable<PbPlanBianual> GetAllAsync();
    }
}
