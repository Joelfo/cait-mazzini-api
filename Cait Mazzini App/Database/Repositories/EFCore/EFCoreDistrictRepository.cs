using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreDistrictRepository : EFCoreGenericRepository<District, int>, IDistrictRepository
    {
        public EFCoreDistrictRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public IList<District> GetAllByCity(int cityId)
        {
            return _dbContext.Set<District>().Where(district => district.City.Id == cityId).ToList();
        }
    }
}
