using Microsoft.EntityFrameworkCore;
using Ortiz_FinalCalidad.DB.Maping;
using Ortiz_FinalCalidad.Models;

namespace Ortiz_FinalCalidad.DB
{
    public class DBEntities : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Ingresos> Ingresos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DBEntities(DbContextOptions<DBEntities> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CuentasMaping());
            modelBuilder.ApplyConfiguration(new IngresosMaping());
            modelBuilder.ApplyConfiguration(new GastosMaping());
        }
    }
}
