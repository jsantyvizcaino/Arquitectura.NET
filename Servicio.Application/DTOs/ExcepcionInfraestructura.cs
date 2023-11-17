using Servicio.Application.Constants;
using Servicio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class ExcepcionInfraestructura : Exception
    {
        public Capa Localidad = Capa.Infraestructura;
        public int Code { get; }

        public ExcepcionInfraestructura(int code) : base(MensajesGlobales.ErroresInfraestructura)
        {
            Code = code;
        }

        public ExcepcionInfraestructura(int code, string mensaje)
            : base($"{MensajesGlobales.ErroresInfraestructura} {mensaje}")
        {
            Code = code;
        }

        public ExcepcionInfraestructura(int code, string mensaje, params object[] args)
            : base($"{MensajesGlobales.ErroresInfraestructura} {string.Format(mensaje, args)}")
        {
            Code = code;
        }
    }
}
