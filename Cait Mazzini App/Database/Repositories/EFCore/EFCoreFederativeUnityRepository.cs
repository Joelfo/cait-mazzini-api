using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreFederativeUnityRepository : EFCoreGenericRepository<FederativeUnity, int>, IFederativeUnityRepository 
    {
        public EFCoreFederativeUnityRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<FederativeUnity>> AllByCountry(int countryId)
        {
            return await _dbContext.Set<FederativeUnity>()
                .Where(x => x.Country.Id == countryId)
                .ToListAsync();
        }
    }
}
