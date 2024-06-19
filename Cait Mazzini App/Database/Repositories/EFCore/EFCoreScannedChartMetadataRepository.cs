using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Charts;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreScannedChartMetadataRepository : EFCoreGenericRepository<ScannedChartMetadata, int>, IScannedChartMetadataRepository
    {
        public EFCoreScannedChartMetadataRepository(CaitMazziniDbContext dbContext) : base(dbContext) 
        { 

        }

        public async Task<ScannedChartMetadata> GetByPatient(int patientId)
        {
            return await _dbContext.Set<ScannedChartMetadata>().FirstOrDefaultAsync(x => x.Patient.Id == patientId);
        }
    }
}
