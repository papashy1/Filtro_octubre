
namespace Dominio.Entities
{
    public class FormaPago : BaseEntity
    {
        public string FormaPagoDescripcion { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}