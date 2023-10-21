
namespace Dominio.Entities
{
    public class Prenda : BaseEntity
    {
        public int IdPrenda { get; set; }
        public string NombrePrenda { get; set; }
        public decimal ValorUnitCop { get; set; }
        public decimal ValorUnitUsd { get; set; }
        public Estado Estado { get; set; }
        public int IdEstadoFk { get; set; }
        public TipoProteccion TipoProteccion { get; set; }
        public int IdTipoProteccionFk { get; set; }
        public Genero Genero { get; set; }
        public int IdGeneroFk { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }

        public ICollection<Inventario> Inventarios { get; set; }

        public ICollection<DetalleOrden> DetalleOrdens { get; set; }

    }
}