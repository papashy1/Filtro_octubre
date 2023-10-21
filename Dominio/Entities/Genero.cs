
namespace Dominio.Entities
{
    public class Genero : BaseEntity
    {
        public string GeneroDescription { get; set; }
        public ICollection<Prenda> Prendas { get; set; }
        
    }
}