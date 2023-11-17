using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Servicio.Domain.Entities;

namespace Servicio.Infrestructure.ConfiguracionesEF
{
    internal class PbPlanBianualConfig : IEntityTypeConfiguration<PbPlanBianual>
    {
        public void Configure(EntityTypeBuilder<PbPlanBianual> entity)
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("PB_PLAN_BIANUAL");

            entity.Property(e => e.Id)
                .HasColumnName("PB_ID_PLAN_BIANUAL")
                .HasComment("Id Plan Bianual");

            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .HasColumnName("CODIGO")
                .HasComment("Codigo que representa el plan bianual");

            entity.Property(e => e.IdEmpresa)
                .HasColumnName("ID_EMPRESA")
                .HasComment("Id de la empresa que genera el plan bianual");

            entity.Property(e => e.IdEstacion)
                .HasColumnName("ID_ESTACION")
                .HasComment("Id de la estacion");

            entity.Property(e => e.IdEstado)
                .HasColumnName("ID_ESTADO")
                .HasComment("Id del estado en el que se encuentra el mantenimiento");

            entity.Property(e => e.IdTipoEstacion)
                .HasColumnName("ID_TIPO_ESTACION")
                .HasComment("Id del tipo de estacion");

            entity.Property(e => e.IdUnidadNegocio)
                .HasColumnName("ID_UNIDAD_NEGOCIO")
                .HasComment("Id de la unidad de negocio que genera el plan bianual");

            entity.Property(e => e.IdUsuarioCreacion)
                .HasColumnName("ID_USUARIO_CREACION")
                .HasComment("Id Usuario Sistema");

            entity.Property(e => e.PbFechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("PB_FECHA_CREACION")
                .HasComment("Fecha en la que se genera el plan bianual");

            entity.Property(e => e.PbFechaEnvio)
                .HasColumnType("datetime")
                .HasColumnName("PB_FECHA_ENVIO")
                .HasComment("Fecha en la que se envío el palan bianual");

            entity.Property(e => e.PbFechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("PB_FECHA_MODIFICACION")
                .HasComment("Fecha en la que el plan bianual ha sido modificado");

            entity.Property(e => e.PbFechaRevision)
                .HasColumnType("datetime")
                .HasColumnName("PB_FECHA_REVISION");

            entity.Property(e => e.PbModificado)
                .HasColumnName("PB_MODIFICADO")
                .HasComment("Indica si el plan bianual ha sido modificado");

            entity.Property(e => e.PbPlanesRevisados)
                .HasColumnName("PB_PLANES_REVISADOS")
                .HasComment("Indica si los mantenimientos del plan binaual han sido revisados");

            entity.Property(e => e.PbUsuarioAprobacion).HasColumnName("PB_USUARIO_APROBACION");
        }
    }
}
