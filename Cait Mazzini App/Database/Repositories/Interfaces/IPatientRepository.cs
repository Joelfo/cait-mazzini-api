using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient, int>
    {
        IList<Patient> AllByName(string name);
    }
}
