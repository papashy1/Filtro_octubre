
namespace Dominio.Entities
{
    public class InsumoPrenda : BaseEntity
    {
        public int InsumoPrendaCantidad { get; set; }
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }
        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }
    }
}