
namespace Dominio.Entities
{
    public class InventarioTalla : BaseEntity
    {
        public Inventario   Inventario { get; set; }
        public int IdInventarioFk { get; set; }
        public Talla Talla { get; set; }
        public int IdTallaFk { get; set; }
    }
}