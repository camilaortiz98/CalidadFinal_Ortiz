namespace Ortiz_FinalCalidad.Models
{
    public class Ingresos
    {
        public int id { get; set; }
        public int cuentaId { get; set; }
        public string descripcion { get; set; }
        public float monto { get; set; }
        public Cuenta cuenta { get; set; }
    }
}
