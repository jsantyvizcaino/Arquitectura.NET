using AutoMapper;
using AutoMapper.AspNet.OData;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Servicio.Application.Constants;
using Servicio.Application.DTOs;
using Servicio.Application.DTOs.Planbianual;
using Servicio.Domain.Contratos.Entidades;

namespace Servicio.Application.Features.Desconexiones.Queries
{
    internal class PlanesBianualQueryHandler : IRequestHandler<PlanesBianualQuery, IReadOnlyCollection<PlanBianualDto>>
    {
        public readonly ILogger<PlanesBianualQueryHandler> _logger;
        public readonly IPbPlanBianualRepositorio _planBianualRepositorio;
        public readonly IMapper _mapper;

        public PlanesBianualQueryHandler(ILogger<PlanesBianualQueryHandler> logger,
            IPbPlanBianualRepositorio planBianualRepositorio, IMapper mapper)
        {
            _logger = logger;
            _planBianualRepositorio = planBianualRepositorio;
            _mapper = mapper;
        }

        #region Metodos Publicos
        public async Task<IReadOnlyCollection<PlanBianualDto>> Handle(PlanesBianualQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.IniciaConsulta, request));
            var resultado = await _planBianualRepositorio.GetAllAsync().GetQueryAsync(_mapper, request.Filtros);
            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.FinalizaConsulta, request));
            return await resultado.ToListAsync();

        }

        #endregion
    }
}
