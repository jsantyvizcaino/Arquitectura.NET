using Servicio.Domain.Contratos.StoreProcedure;
using Servicio.Domain.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Infrestructure.Repositorios.StoreProcedure
{
    public class BusquedaManiobrasRepositorio : ProcedimientoAlmacenadoSqlRepositorio<SP_OBTENER_MANIOBRAS_BOSNI>, IBusquedaManiobrasRepositorio
    {
        public BusquedaManiobrasRepositorio(BosniContextDb samwebContextoDb) : base(samwebContextoDb)
        {
        }
    }
}
