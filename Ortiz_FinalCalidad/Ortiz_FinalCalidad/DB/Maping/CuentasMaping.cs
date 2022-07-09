using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ortiz_FinalCalidad.Models;

namespace Ortiz_FinalCalidad.DB.Maping
{
    public class CuentasMaping : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> builder)
        {
            builder.ToTable("Cuenta");
            builder.HasKey(o => o.id);

            builder.HasMany<Gasto>(o => o.gastos).WithOne().HasForeignKey(o => o.cuentaId);
            builder.HasMany<Ingresos>(o => o.ingresos).WithOne().HasForeignKey(o => o.cuentaId);
        }
    }
}
