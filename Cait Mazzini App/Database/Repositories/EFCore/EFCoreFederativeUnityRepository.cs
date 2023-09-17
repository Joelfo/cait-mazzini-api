using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models;
using System.Security.Cryptography.X509Certificates;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreFederativeUnityRepository : EFCoreGenericRepository<FederativeUnity, int>, IFederativeUnityRepository 
    {
        public EFCoreFederativeUnityRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public IList<FederativeUnity> AllByCountry(int countryId)
        {
            return _dbContext.Set<FederativeUnity>()
                .Where(x => x.Country.Id == countryId)
                .ToList();
        }
    }
}
