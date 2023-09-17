using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.Interfaces
{
    public interface IVitalSignsMeasurementRepository : IGenericRepository<VitalSignsMeasurement, int>
    {
        public IList<VitalSignsMeasurement> AllByPatient(int patientId);
    }
}
