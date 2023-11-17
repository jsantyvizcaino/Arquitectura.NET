using Servicio.Domain.Contratos;
using Servicio.Domain.Entities.Abstract;

namespace Servicio.Domain.Entities
{
    public class PbPlanBianual : EntidadBase<int>, IAgregadoRaiz
    {
        public PbPlanBianual() : base(0)
        {
        }

        /// <summary>
        /// Id Plan Bianual
        /// </summary>
        public override int Id { get; set; }
        /// <summary>
        /// Id Usuario Sistema
        /// </summary>
        public Guid IdUsuarioCreacion { get; set; }
        /// <summary>
        /// Id del estado en el que se encuentra el mantenimiento
        /// </summary>
        public int IdEstado { get; set; }
        /// <summary>
        /// Id de la empresa que genera el plan bianual
        /// </summary>
        public int IdEmpresa { get; set; }
        /// <summary>
        /// Id de la unidad de negocio que genera el plan bianual
        /// </summary>
        public int IdUnidadNegocio { get; set; }
        /// <summary>
        /// Id del tipo de estacion
        /// </summary>
        public int IdTipoEstacion { get; set; }
        /// <summary>
        /// Id de la estacion
        /// </summary>
        public int IdEstacion { get; set; }
        /// <summary>
        /// Fecha en la que se genera el plan bianual
        /// </summary>
        public DateTime PbFechaCreacion { get; set; }
        /// <summary>
        /// Fecha en la que el plan bianual ha sido modificado
        /// </summary>
        public DateTime? PbFechaModificacion { get; set; }
        /// <summary>
        /// Codigo que representa el plan bianual
        /// </summary>
        public string? Codigo { get; set; }
        /// <summary>
        /// Indica si el plan bianual ha sido modificado
        /// </summary>
        public bool? PbModificado { get; set; }
        /// <summary>
        /// Indica si los mantenimientos del plan binaual han sido revisados
        /// </summary>
        public bool? PbPlanesRevisados { get; set; }
        /// <summary>
        /// Fecha en la que se envío el palan bianual
        /// </summary>
        public DateTime? PbFechaEnvio { get; set; }
        public DateTime? PbFechaRevision { get; set; }
        public Guid? PbUsuarioAprobacion { get; set; }
    }
}
