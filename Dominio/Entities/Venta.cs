
namespace Dominio.Entities
{
    public class Venta : BaseEntity
    {
        public DateTime VentaFecha { get; set; }
        public Empleado Empleado { get; set; }
        public int IdEmpleadofk { get; set; }
        public Cliente Cliente { get; set; }
        public int IdClienteFk { get; set; }
        public FormaPago FormaPago {get; set; }
        public int IdFormaPagoFk { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
    }
}