using MediatR;
using Servicio.Domain.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.Features.StoreProcedure.Bosni
{
    public class BusquedaManiobrasQuery : IRequest<List<SP_OBTENER_MANIOBRAS_BOSNI>>
    {
        public long IdSam { get; set; }

        public BusquedaManiobrasQuery(long idSam)
        {
            IdSam = idSam;
        }
    }
}
