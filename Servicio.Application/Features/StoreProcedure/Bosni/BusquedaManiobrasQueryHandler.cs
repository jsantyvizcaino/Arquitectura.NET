using MediatR;
using Microsoft.Extensions.Logging;
using Servicio.Application.DTOs.ProcedimientoAlmacenados;
using Servicio.Domain.Contratos.StoreProcedure;
using Servicio.Domain.StoreProcedure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.Features.StoreProcedure.Bosni
{
    internal class BusquedaManiobrasQueryHandler : IRequestHandler<BusquedaManiobrasQuery, List<SP_OBTENER_MANIOBRAS_BOSNI>>
    {
        private readonly ILogger<BusquedaManiobrasQueryHandler> _logger;
        private readonly IBusquedaManiobrasRepositorio _busquedaManiobrasRepositorio;

        public BusquedaManiobrasQueryHandler(ILogger<BusquedaManiobrasQueryHandler> logger,
                                             IBusquedaManiobrasRepositorio busquedaManiobrasRepositorio)
        {
            _logger = logger;
            _busquedaManiobrasRepositorio = busquedaManiobrasRepositorio;
        }

        public Task<List<SP_OBTENER_MANIOBRAS_BOSNI>> Handle(BusquedaManiobrasQuery request, CancellationToken cancellationToken)
        {
            var listParametros = new List<Parametro> {
                new Parametro("SAM_ID",request.IdSam),

            };

            var resultado = _busquedaManiobrasRepositorio.EjecutarComando(Procedimiento.Ejecutar(nameof(SP_OBTENER_MANIOBRAS_BOSNI), listParametros)).ToList();
            return Task.FromResult(resultado);
        }
    }
}
