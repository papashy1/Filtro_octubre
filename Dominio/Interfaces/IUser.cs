using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IUser : IGeneric<User>
    {
        Task<User> GetByUsername(string username);
        Task<User> GetByRefreshToken(string refreshToken);
    }
