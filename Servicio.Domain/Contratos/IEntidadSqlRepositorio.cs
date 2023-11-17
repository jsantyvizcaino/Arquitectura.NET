using Ardalis.Specification;
using Servicio.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Domain.Contratos
{
    public interface IEntidadSqlRepositorio<T, TIdentificador> : IRepositoryBase<T> where T : EntidadBase<TIdentificador>, IAgregadoRaiz
    {
    }
}
