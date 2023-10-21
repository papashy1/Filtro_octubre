
namespace Dominio.Entities
{
    public class TipoEstado : BaseEntity
    {
        public string TipoEstadoDescripcion { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}