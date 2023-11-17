using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Domain.Contratos
{
    public interface IProcedimientoAlmacenadoSqlRepositorio<T>
    {
        IQueryable<T> EjecutarComando(FormattableString query);
    }
}
