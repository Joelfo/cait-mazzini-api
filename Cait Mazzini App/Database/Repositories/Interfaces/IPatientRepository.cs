using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IPatientRepository : IGenericRepository<Patient, int>
    {
        Task<IList<Patient>> AllByName(string name);
    }
}
