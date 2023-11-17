using FluentValidation.Results;
using Servicio.Application.Constants;
using Servicio.Domain.Enums;

namespace Servicio.Application.DTOs
{
    public class ExcepcionPrecondicion : Exception
    {
        public Capa Localidad = Capa.Aplicacion;
        public int Code { get; }
        public IList<string> Errores { get; }

        public ExcepcionPrecondicion(int code) : base(MensajesGlobales.ErroresPrecondiciones)
        {
            Code = code;
            Errores = new List<string>();
        }

        public ExcepcionPrecondicion(int code, IEnumerable<ValidationFailure> errores) : this(code)
        {
            Code = code;
            foreach (var error in errores)
            {
                Errores.Add(error.ErrorMessage);
            }
        }
    }
}
