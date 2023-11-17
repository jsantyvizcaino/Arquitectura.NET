using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Servicio.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Servicio.Infrestructure.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlerMiddleware> _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exeption)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                RespuestaError<string> modeloRespuestaError = RespuestaError<string>.Error(500, exeption, "Error Interno. Contactese con el administrador." + exeption.Message);
                if (exeption is ExcepcionInfraestructura)
                {
                    var ex = exeption as ExcepcionInfraestructura;
                    modeloRespuestaError = RespuestaError<string>.Error(ex.Code, ex, ex.Message);
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                }

                if (exeption is ExcepcionPrecondicion)
                {
                    var ex = exeption as ExcepcionPrecondicion;
                    modeloRespuestaError = RespuestaError<string>.Error(ex.Code, ex, $"{ex.Message} {string.Join(", ", ex.Errores)}");
                    response.StatusCode = (int)HttpStatusCode.PreconditionFailed;
                }

                if (exeption is ExcepcionDominio)
                {
                    var ex = exeption as ExcepcionDominio;
                    modeloRespuestaError = RespuestaError<string>.Error(ex.Code, ex, ex.Message);
                    response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                }
                _logger.LogError($"Error: {exeption.Message}:{exeption.InnerException?.Message}, Pila de Excepcion: {exeption.StackTrace}");
                await response.WriteAsync(JsonSerializer.Serialize(modeloRespuestaError));
            }
        }

    }
}
