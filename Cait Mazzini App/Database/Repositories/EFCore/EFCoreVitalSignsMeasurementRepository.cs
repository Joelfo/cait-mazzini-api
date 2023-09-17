using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Models;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreVitalSignsMeasurementRepository : EFCoreGenericRepository<VitalSignsMeasurement, int>, IVitalSignsMeasurementRepository
    {
        public EFCoreVitalSignsMeasurementRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public IList<VitalSignsMeasurement> AllByPatient(int patientId)
        {
            return _dbContext.Set<VitalSignsMeasurement>()
                .Where(vitalSignsMeasurement => vitalSignsMeasurement.Patient.Id == patientId)
                .ToList();
        }
    }
}
