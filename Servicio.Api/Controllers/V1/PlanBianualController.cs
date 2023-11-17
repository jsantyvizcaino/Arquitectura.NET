using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Servicio.Application.Constants;
using Servicio.Application.DTOs.Planbianual;
using Servicio.Application.DTOs;
using Servicio.Application.Features.Desconexiones.Queries;
using Servicio.Infrestructure.Controladores;
using Servicio.Infrestructure.FiltrosAccion;

namespace Servicio.Api.Controllers.V1
{
    /// <summary>
    /// 
    /// </summary>
    [ApiVersion("1")]
    [ApiController]
    public class PlanBianualController : ApiBaseController
    {
        #region Propiedades y Constructor
        private readonly ILogger<PlanBianualController> _logger;

        /// <summary>
        /// PlanBianualController
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="mediator"></param>
        public PlanBianualController(ILogger<PlanBianualController> logger, IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }
        #endregion

        /// <summary>
        /// ObtenerPlanesBianual
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("planes-bianual")]
        [EnableQuery]
        [RespuestaOdataActionFilter]
        public async Task<IActionResult> ObtenerPlanesBianual(ODataQueryOptions<PlanBianualDto> filtros)
        {
            var resultado = await Mediator.Send(new PlanesBianualQuery(filtros));
            if (resultado.Any())
            {
                return Ok(resultado);
            }
            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.NoExistenDatos, nameof(ObtenerPlanesBianual)));
            return NoContent();
        }
    }
}
