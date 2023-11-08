using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IDistrictRepository : IGenericRepository<District, int>
    {
        public Task<IList<District>> GetAllByCity(int cityId);
    }
}
