
namespace Dominio.Entities
{
    public class Color : BaseEntity
    {
        public string ColorDescripcion { get; set; }
        public ICollection<DetalleOrden> DetalleOrdens {get; set; }
    }
}