
namespace Dominio.Entities
{
    public class Estado : BaseEntity
    {
        public string EstadoDescripcion {get; set; }
        public TipoEstado TipoEstado {get; set; }
        public int IdTipoEstadoFk {get; set; }
        public ICollection<Prenda> Prendas {get; set; }
        public ICollection<DetalleOrden> DetalleOrdens {get; set; }
        public ICollection<Orden> Ordens {get; set; }
    }
}