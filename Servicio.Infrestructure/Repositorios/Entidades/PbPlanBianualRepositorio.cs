using Ardalis.Specification;
using Servicio.Domain.Contratos;
using Servicio.Domain.Contratos.Entidades;
using Servicio.Domain.Entities;

namespace Servicio.Infrestructure.Repositorios.Entidades
{
    public class PbPlanBianualRepositorio : EntidadSqlRepositorio<PbPlanBianual, int>, IPbPlanBianualRepositorio
    {
        private readonly BosniContextDb _samwebContextoDb;

        public PbPlanBianualRepositorio(BosniContextDb samwebContextoDb,
            ISpecificationEvaluator specificationEvaluator) : base(samwebContextoDb, specificationEvaluator)
        {
            _samwebContextoDb = samwebContextoDb;
        }

        public IUnidadDeTrabajo UnidadDeTrabajo => _samwebContextoDb;

        public IQueryable<PbPlanBianual> GetAllAsync()
        {
            return _samwebContextoDb.Set<PbPlanBianual>();
        }
    }
}
