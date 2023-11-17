using Servicio.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Domain.StoreProcedure
{
    public class SP_OBTENER_MANIOBRAS_BOSNI : EntidadBase<int>
    {
        public SP_OBTENER_MANIOBRAS_BOSNI() : base(0)
        {
        }

        public long? EventoId { get; set; }
        public int? EventoClase { get; set; }
        public string? EventoClaseNombre { get; set; }
        public DateTime? EventoFecha { get; set; }
        public string? EmpresaNombre { get; set; }
        public string? EstacionNombre { get; set; }
        public string? ElementoNombre { get; set; }
        public decimal? VoltajeValor { get; set; }
        public string? EventoNombre { get; set; }
        public string? CalifNombre { get; set; }
        public int? EventoNumRedsp { get; set; }
        public decimal? EventoValor { get; set; }
        public string? EventoNota { get; set; }
        public int? SamId { get; set; }
    }
}
