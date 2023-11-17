using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Application.DTOs.Planbianual
{
    public class PlanBianualDto
    {
        public int Id { get; set; }
        public Guid IdUsuarioCreacion { get; set; }

        public string? Codigo { get; set; }

        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }

        public int IdUnidadNegocio { get; set; }
        public int IdTipoEstacion { get; set; }
        public int IdEstacion { get; set; }
        public bool Modificado { get; set; }
        public bool PlanesRevisados { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaRevision { get; set; }
        public Guid? UsuarioAprobacion { get; set; }
    }
}
