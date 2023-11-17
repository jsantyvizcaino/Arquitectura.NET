using Servicio.Domain.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Domain.Contratos.StoreProcedure
{
    public interface IBusquedaManiobrasRepositorio : IProcedimientoAlmacenadoSqlRepositorio<SP_OBTENER_MANIOBRAS_BOSNI>
    {
    }
}
