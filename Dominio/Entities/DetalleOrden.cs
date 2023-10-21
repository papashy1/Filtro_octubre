
namespace Dominio.Entities
{
    public class DetalleOrden : BaseEntity
    {
        public int CantidadProducir {get; set; }
        public int cantidadProducida {get; set; }
        public Orden Orden { get; set; }
        public int IdOrdenFk {get; set; }
        public Prenda Prenda { get; set; }
        public int IdPrendaFk {get; set; }
        public Color Color { get; set; }
        public int IdColorFk {get; set; }
        public Estado Estado { get; set; }   
        public int IdEstadoFk {get; set; }
 
    }
}