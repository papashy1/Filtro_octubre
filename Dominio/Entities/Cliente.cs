
namespace Dominio.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaRegistro {get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public Municipio Municipio { get; set; }
        public int IdMunicipioFk { get; set; }
        public ICollection<Orden> Ordens { get; set; }
        public ICollection<Venta> Ventas { get; set; }

    }
}