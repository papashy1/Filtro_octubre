
namespace Dominio.Entities
{
    public class UserRol
    {
        public int IdUserFk { get; set; }
        public User Usuario { get; set; }
        public int IdRolFk { get; set; }
        public Rol Rol { get; set; }
    }
}
