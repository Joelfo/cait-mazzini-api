using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IFederativeUnityRepository : IGenericRepository<FederativeUnity, int>
    {
        Task<IList<FederativeUnity>> AllByCountry(int countryId);
    }
}
