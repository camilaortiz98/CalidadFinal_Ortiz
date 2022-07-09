using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ortiz_FinalCalidad.Models;

namespace Ortiz_FinalCalidad.DB.Maping
{
    public class GastosMaping : IEntityTypeConfiguration<Gasto>
    {
        public void Configure(EntityTypeBuilder<Gasto> builder)
        {
            builder.ToTable("Gastos");
            builder.HasKey(o => o.id);

            builder.HasOne(o => o.cuenta).WithMany().HasForeignKey(o => o.cuentaId);
        }
    }
}
