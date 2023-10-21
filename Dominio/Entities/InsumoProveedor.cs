
namespace Dominio.Entities
{
    public class InsumoProveedor
    {
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }
        public Proveedor Proveedor { get; set; }
        public int IdProveedorFk { get; set; }
    }
}