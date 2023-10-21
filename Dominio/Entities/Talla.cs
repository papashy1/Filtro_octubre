
namespace Dominio.Entities
{
    public class Talla : BaseEntity
    {
        public string TallaDescripcion { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }

    }
}