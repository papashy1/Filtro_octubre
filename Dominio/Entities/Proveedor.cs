
namespace Dominio.Entities
{
    public class Proveedor : BaseEntity
    {
        public string NitProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public Municipio Municipio {get; set; }
        public int IdMunicipioFk { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedors { get; set; }
        public ICollection<Insumo> Insumos { get; set; } = new HashSet<Insumo>();
    }
}