using System;

namespace Servicio.Application.DTOs
{
    public static class Mensajeria
    {
        public static string ObtenerMensajeError(Exception ex)
        {
            var mensajeError = ex.Message;

            if (ex.InnerException != null)
            {
                mensajeError += " " + ex.InnerException.Message;
            }
            return mensajeError;
        }

        public static string GenerarMensaje(string msg, params object[] args)
        {
            return string.Format(msg, args);
        }
    }
}
