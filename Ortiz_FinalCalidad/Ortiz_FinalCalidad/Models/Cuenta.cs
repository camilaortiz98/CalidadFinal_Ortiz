namespace Ortiz_FinalCalidad.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String categoria { get; set; }
        public decimal saldoInicial { get; set; }
        public char moneda { get; set; }

        public List<Gasto> gastos { get; set; }

        public List<Ingresos> ingresos { get; set; }

    }
}
