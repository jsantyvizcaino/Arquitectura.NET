using Servicio.Application.Constants;
using Servicio.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs
{
    public class ExcepcionDominio : Exception
    {
        public Capa Localidad = Capa.Dominio;
        public int Code { get; }

        public ExcepcionDominio(int code) : base(MensajesGlobales.ErroresInfraestructura)
        {
            Code = code;
        }

        public ExcepcionDominio(int code, string mensaje)
            : base($"{MensajesGlobales.ErroresInfraestructura} {mensaje}")
        {
            Code = code;
        }

        public ExcepcionDominio(int code, string mensaje, params object[] args)
            : base($"{MensajesGlobales.ErroresInfraestructura} {string.Format(mensaje, args)}")
        {
            Code = code;
        }
    }
}
