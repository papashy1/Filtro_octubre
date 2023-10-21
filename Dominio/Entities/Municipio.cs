
namespace Dominio.Entities
{
    public class Municipio : BaseEntity
    {
       public string NombreMunicipio {get; set; }
       public Departamento Departamentos {get; set; }
       public int IdDepartamentoFk {get; set; }
       public ICollection<Empresa> Empresas {get; set; }
       public ICollection<Cliente> Clientes {get; set; }
       public ICollection<Empleado> Empleados {get; set; }
       public ICollection<Proveedor> Proveedors {get; set; }

    }
}