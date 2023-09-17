using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCorePatientRepository : EFCoreGenericRepository<Patient, int>, IPatientRepository
    {
        public EFCorePatientRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
            
        }

        public IList<Patient> AllByName(string name)
        {
            return _dbContext.Set<Patient>()
                .Where(x => EF.Functions.Like(x.Name, $"%{name}%"))
                .ToList();
        }
    }
}
