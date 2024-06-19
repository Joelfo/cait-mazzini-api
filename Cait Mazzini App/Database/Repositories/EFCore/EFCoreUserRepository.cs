using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreUserRepository : EFCoreGenericRepository<User, int>, IUserRepository
    {
        public EFCoreUserRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<User> GetByCpf(string cpf)
        {
            return await _dbContext.Set<User>().FirstOrDefaultAsync(x => x.Cpf == cpf);

        }
    }
}
