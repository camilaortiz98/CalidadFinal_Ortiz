using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ortiz_FinalCalidad.Models;

namespace Ortiz_FinalCalidad.DB.Maping
{
    public class IngresosMaping : IEntityTypeConfiguration<Ingresos>
    {
        public void Configure(EntityTypeBuilder<Ingresos> builder)
        {
            builder.ToTable("Ingresos");
            builder.HasKey(o => o.id);
            builder.HasOne(o => o.cuenta).WithMany().HasForeignKey(o => o.cuentaId);
        }
    }
}
