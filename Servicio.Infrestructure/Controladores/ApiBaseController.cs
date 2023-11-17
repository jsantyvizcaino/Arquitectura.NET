using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace Servicio.Infrestructure.Controladores
{
    [ApiController]
    [Route("api/v{version:apiVersion}")]
    public class ApiBaseController: ODataController
    {
        private IMediator _mediator;

        /// <summary>
        /// IMediator
        /// </summary>
        protected IMediator Mediator => _mediator;

        /// <summary>
        /// ApiBaseController
        /// </summary>
        public ApiBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
