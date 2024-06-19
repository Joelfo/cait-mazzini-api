using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User, int>
    {
        Task<User> GetByCpf(string cpf);
    }
}
