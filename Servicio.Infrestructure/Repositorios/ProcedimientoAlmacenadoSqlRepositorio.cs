using Microsoft.EntityFrameworkCore;
using Servicio.Domain.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Infrestructure.Repositorios
{
    public class ProcedimientoAlmacenadoSqlRepositorio<T> : IProcedimientoAlmacenadoSqlRepositorio<T> where T : class
    {
        private readonly DbContext _contextoDb;

        public ProcedimientoAlmacenadoSqlRepositorio(DbContext contextoDb)
        {
            _contextoDb = contextoDb;
        }

        public IQueryable<T> EjecutarComando(FormattableString query)
        {
            IQueryable<T> resultado = _contextoDb.Set<T>().FromSqlRaw(query.ToString());
            return resultado;
        }

    }
}
