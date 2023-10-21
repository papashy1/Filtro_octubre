
namespace Dominio.Entities
{
    public class Insumo : BaseEntity
    {
        public string NombreInsumo { get; set; }
        public decimal ValorUnit { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedors { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; } = new HashSet<Proveedor>();

    }
}