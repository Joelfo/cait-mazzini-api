using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Charts;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreVitalSignsMeasurementRepository : EFCoreGenericRepository<VitalSignsMeasurement, int>, IVitalSignsMeasurementRepository
    {
        public EFCoreVitalSignsMeasurementRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<VitalSignsMeasurement>> AllByPatient(int patientId)
        {
            return await _dbContext.Set<VitalSignsMeasurement>()
                .Where(vitalSignsMeasurement => vitalSignsMeasurement.Patient.Id == patientId)
                .ToListAsync();
        }
    }
}
