using Ortiz_FinalCalidad.DB;
using Ortiz_FinalCalidad.Models;

namespace Ortiz_FinalCalidad.Repositorio
{
    public interface InterfaceCuentaRepositorio
    {
        public List<Cuenta> cuentas();
        public void add(Cuenta cuenta);
    }
    public class CuentaRepositorio : InterfaceCuentaRepositorio
    {
        private readonly DBEntities entidades;

        public CuentaRepositorio(DBEntities _entidades)
        {
            this.entidades = _entidades;
        }
        public List<Cuenta> cuentas()
        {
            return entidades.Cuentas.ToList();
        }
        public void add(Cuenta cuenta)
        {
            entidades.Cuentas.Add(cuenta);
            entidades.SaveChanges();
        }
    }
}
