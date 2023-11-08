using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCorePatientRepository : EFCoreGenericRepository<Patient, int>, IPatientRepository
    {
        public EFCorePatientRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<IList<Patient>> AllByName(string name)
        {
            return await _dbContext.Set<Patient>()
                .Where(x => EF.Functions.Like(x.Name, $"%{name}%"))
                .ToListAsync();
        }
    }
}
