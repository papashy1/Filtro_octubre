
namespace Dominio.Entities
{
    public class TipoProteccion : BaseEntity
    {
        public string TipoProteccionDescripcion { get; set; }
        public ICollection<Prenda> Prendas { get; set; }

    }
}