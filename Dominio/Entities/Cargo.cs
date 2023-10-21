
namespace Dominio.Entities
{
    public class Cargo : BaseEntity
    {
        public string CargoDescripcion { get; set; }
        public decimal SueldoBase {get; set; }
        public ICollection<Empleado> Empleados {get; set; }
    }
}