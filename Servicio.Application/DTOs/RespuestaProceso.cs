using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class RespuestaProceso<T> : RespuestaBase
    {
        public T Dato { get; set; }

        public static RespuestaProceso<T> Exitosa<T>(T value, int total = 0)
        {
            return new RespuestaProceso<T>
            {
                EsExitoso = true,
                Codigo = 0,
                Mensaje = "Proceso Exitoso",
                Dato = value,
                Total = total
            };
        }
    }
}
