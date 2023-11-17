using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Servicio.Domain.Contratos;
using Servicio.Domain.Entities.Abstract;

namespace Servicio.Infrestructure.Repositorios
{
    public class EntidadSqlRepositorio<T, TIdentificador> : RepositoryBase<T>, IEntidadSqlRepositorio<T, TIdentificador> where T : EntidadBase<TIdentificador>, IAgregadoRaiz
    {
        private readonly DbContext _contextoDb;

        public EntidadSqlRepositorio(DbContext contextoDb) : base(contextoDb)
        {
            _contextoDb = contextoDb;
        }

        public EntidadSqlRepositorio(DbContext contextoDb, ISpecificationEvaluator specificationEvaluator)
            : base(contextoDb, specificationEvaluator)
        {
            _contextoDb = contextoDb;
        }

        public override async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().Add(entity);
            return entity;
        }

        public override async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().AddRange(entities);
            return entities;
        }

        public override async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().Update(entity);
        }

        public override async Task UpdateRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().UpdateRange(entities);
        }

        public override async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().Remove(entity);
        }

        public override async Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            _contextoDb.Set<T>().RemoveRange(entities);
        }
    }
}
