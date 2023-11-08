using CaitMazziniApp.Models.Charts;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IVitalSignsMeasurementRepository : IGenericRepository<VitalSignsMeasurement, int>
    {
        public Task<IList<VitalSignsMeasurement>> AllByPatient(int patientId);
    }
}
