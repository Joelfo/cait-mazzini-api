using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface IFederativeUnityRepository : IGenericRepository<FederativeUnity, int>
    {
        IList<FederativeUnity> AllByCountry(int countryId);
    }
}
