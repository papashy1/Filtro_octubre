
namespace Dominio.Entities
{
    public class TipoPersona : BaseEntity
    {
        public string NombreTipoPersona { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Proveedor> Proveedors { get; set; }
    }
}