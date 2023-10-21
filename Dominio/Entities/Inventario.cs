
namespace Dominio.Entities
{
    public class Inventario : BaseEntity
    {
        public int CodInv { get; set; }
        public decimal ValorVtaCop { get; set; }
        public decimal ValorVtaUsd { get; set; }
        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }
        public ICollection<DetalleVenta> DetalleVentas { get; set; }
        public ICollection<InventarioTalla> InventarioTallas { get; set; }

    }
}