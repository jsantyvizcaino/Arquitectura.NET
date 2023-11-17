using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Servicio.Domain.StoreProcedure;

namespace Servicio.Infrestructure.ConfiguracionesEF.StoreProcedure
{
    internal class FntObtenerManiobrasConfig : IEntityTypeConfiguration<SP_OBTENER_MANIOBRAS_BOSNI>
    {
        public void Configure(EntityTypeBuilder<SP_OBTENER_MANIOBRAS_BOSNI> builder)
        {
            builder.HasNoKey();

            builder.Ignore(t => t.Id);

            builder.Property(e => e.EventoId)
              .HasColumnName("EVENTO_ID");

            builder.Property(e => e.EventoClase)
               .HasColumnName("EVENTO_CLASE");

            builder.Property(e => e.EventoClaseNombre)
               .HasColumnName("EVENTO_CLASE_NOMBRE");

            builder.Property(e => e.EventoFecha)
               .HasColumnName("EVENTO_FECHA");
            builder.Property(e => e.EmpresaNombre)
               .HasColumnName("EMPRESA_NOMBRE");
            builder.Property(e => e.EstacionNombre)
               .HasColumnName("ESTACION_NOMBRE");
            builder.Property(e => e.ElementoNombre)
               .HasColumnName("ELEMENTO_NOMBRE");
            builder.Property(e => e.VoltajeValor)
               .HasColumnName("VOLTAJE_VALOR");

            builder.Property(e => e.EventoNombre)
               .HasColumnName("TPB_EVENTO_NOMBRE");

            builder.Property(e => e.CalifNombre)
               .HasColumnName("TPB_CALIF_NOMBRE");
            builder.Property(e => e.EventoNumRedsp)
               .HasColumnName("EVENTO_NUM_REDSP");

            builder.Property(e => e.EventoValor)
               .HasColumnName("EVENTO_VALOR");
            builder.Property(e => e.EventoNota)
               .HasColumnName("EVENTO_NOTA");

            builder.Property(e => e.SamId)
               .HasColumnName("SAM_ID");


        }
    }
}
