using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class RespuestaError<T> : RespuestaProceso<T>
    {
        public static RespuestaError<T> Error(string mensaje)
        {
            var respuestaProcesoErroneo = new RespuestaError<T>
            {
                EsExitoso = false,
                Mensaje = mensaje,
                Codigo = 1,
                Detalle = mensaje
            };

            return respuestaProcesoErroneo;
        }

        public static RespuestaError<T> Error(RespuestaBase respuesta)
        {
            var respuestaProcesoErroneo = new RespuestaError<T>
            {
                EsExitoso = false,
                Mensaje = respuesta.Mensaje,
                Codigo = respuesta.Codigo,
                Detalle = respuesta.ObtenerDetalle()
            };

            return respuestaProcesoErroneo;
        }

        public static RespuestaError<T> Error(Exception exception, string mensaje)
        {
            var respuestaProcesoErroneo = new RespuestaError<T>
            {
                EsExitoso = false,
                Mensaje = mensaje,
                Codigo = exception.GetHashCode(),
                Detalle = (exception.InnerException != null
                ? $"Error: {exception.Message}, Inner Exception: {exception.InnerException.Message}"
                : $"Error: {exception.Message}") + $"StackTrace : {exception.StackTrace}"
            };

            return respuestaProcesoErroneo;
        }

        public static RespuestaError<T> Error(int codigo, Exception exception, string mensaje)
        {
            var respuestaProcesoErroneo = new RespuestaError<T>
            {
                EsExitoso = false,
                Mensaje = mensaje,
                Codigo = codigo,
                Detalle = (exception.InnerException != null
                ? $"Error: {exception.Message}, Inner Exception: {exception.InnerException.Message}"
                : $"Error: {exception.Message}") + $"StackTrace : {exception.StackTrace}"
            };

            return respuestaProcesoErroneo;
        }
    }
}
