using MediatR;
using Microsoft.AspNetCore.Mvc;
using Servicio.Application.Constants;
using Servicio.Application.DTOs;
using Servicio.Application.Features.StoreProcedure.Bosni;
using Servicio.Infrestructure.Controladores;

namespace Servicio.Api.Controllers.V1
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    public class ObtenerManiobrasController : ApiBaseController
    {
        private readonly ILogger<ObtenerManiobrasController> _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="mediator"></param>
        public ObtenerManiobrasController(ILogger<ObtenerManiobrasController> logger,
            IMediator mediator) : base(mediator)
        {
            _logger = logger;
        }

        #region Metodos Get
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idEjecucion"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("maniobras-bosni")]
        public async Task<IActionResult> ObtenerManiobrasBosni([FromQuery] long idEjecucion)
        {
            var resultado = await Mediator.Send(new BusquedaManiobrasQuery(idEjecucion));
            if (resultado.Any())
            {
                return Ok(resultado);
            }
            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.NoExistenDatos, nameof(ObtenerManiobrasBosni)));
            return NoContent();
        }
        #endregion
    }
}
