using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreDistrictRepository : EFCoreGenericRepository<District, int>, IDistrictRepository
    {
        public EFCoreDistrictRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<District>> GetAllByCity(int cityId)
        {
            return await _dbContext.Set<District>().Where(district => district.City.Id == cityId).ToListAsync();
        }
    }
}
