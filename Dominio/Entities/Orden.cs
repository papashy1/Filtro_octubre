
namespace Dominio.Entities
{
    public class Orden : BaseEntity
    {
        public DateTime OrdenFecha { get; set; }
        public Empleado Empleado { get; set; }
        public int IdEmpleadoFk { get; set; }
        public Cliente Cliente { get; set; }
        public int IdClienteFk { get; set; }
        public Estado Estado { get; set; }
        public int IdEstadoFk { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }

    }
}