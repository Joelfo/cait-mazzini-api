using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface IDistrictRepository : IGenericRepository<District, int>
    {
        public IList<District> GetAllByCity(int cityId);
    }
}
