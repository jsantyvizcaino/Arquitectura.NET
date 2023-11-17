using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio.Domain.Extensions;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using Servicio.Application.DTOs;
using Servicio.Application.Constants;

namespace Servicio.Infrestructure.Behaivors
{
    public class ValidadorPipelineBahavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        #region Propiedades y Constructor

        private readonly ILogger<ValidadorPipelineBahavior<TRequest, TResponse>> _logger;
        private readonly IValidator<TRequest>[] _validators;

        public ValidadorPipelineBahavior(IValidator<TRequest>[] validators,
            ILogger<ValidadorPipelineBahavior<TRequest, TResponse>> logger)
        {
            _validators = validators;
            _logger = logger;

        }

        #endregion

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (!_validators.Any())
                return await next();

            var typeName = request.GetTypeNameOfGeneric();

            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.EjecucionValidadores, typeName));

            var resultadoErrores = await Task.WhenAll(_validators.Select(t => t.ValidateAsync(request, cancellationToken)));

            var errores = resultadoErrores
                .SelectMany(r => r.Errors).Where(e => e != null).ToList();

            if (errores.Any())
            {
                _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.ErroresValidadores, typeName));
                throw new ExcepcionPrecondicion(errores.GetHashCode(), errores);
            }

            _logger.LogInformation(Mensajeria.GenerarMensaje(MensajesGlobales.NoErroresValidadores, typeName));
            return await next();
        }
    }
}
