
namespace Dominio.Entities
{
    public class Empleado : BaseEntity
    {
        public string IdEmpleado {get; set; }
        public string NombreEmpleado {get; set; }
        public DateTime FechaIngreso {get; set; }
        public Cargo Cargo {get; set; }
        public int IdCargoFk {get; set; }
        public Municipio Municipio {get; set; }
        public int IdMunicipioFk {get; set; }
        public ICollection<Venta> Ventas {get; set; }
        public ICollection<Orden> Ordens {get; set; }
    }
}