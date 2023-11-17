using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class RespuestaBase
    {
        public bool EsExitoso { get; set; }
        public int Codigo { get; set; }
        public int Total { get; set; }
        public string? Mensaje { get; set; }
        protected string Detalle { get; set; }

        public void EscribirDetalle<T>(ILogger<T> logger)
        {
            logger.LogError(Detalle);
        }

        public string ObtenerDetalle()
        {
            return Detalle;
        }
    }
}
