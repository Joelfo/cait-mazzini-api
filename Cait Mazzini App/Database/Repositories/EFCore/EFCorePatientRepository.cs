using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCorePatientRepository : EFCoreGenericRepository<Patient, int>, IPatientRepository
    {
        public EFCorePatientRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<IList<Patient>> AllByName(string name)
        {
            return await _dbContext.Set<Patient>()
                .Where(x => EF.Functions.Like(x.Name, $"%{name}%"))
                .ToListAsync();
        }

        public async Task<IList<PatientBasicInfo>> AllBasicInfoByName(string name)
        {
            return await _dbContext.Set<Patient>()
                .Select<Patient, PatientBasicInfo>(x => new() {Id = x.Id, Name = x.Name, RecordCode = x.RecordCode})
                .Where(x => EF.Functions.Like(x.Name, $"%{name}%"))
                .ToListAsync();
        }

        public async Task<PatientRelationshipsInfo> ShowRelationshipsInfo(int id)
        {
            return await _dbContext.Set<Patient>()
                .Select(x => new PatientRelationshipsInfo () { 
                    Id = x.Id,
                    Name = x.Name, 
                    RecordCode = x.RecordCode,
                    HasClinicalHistory = x.ClinicalHistory != null,
                    HasLifeHabitsInfo = x.LifeHabitsInfo != null,
                    HasScannedChart = x.ScannedChartMetadata != null,
                     })
                .FirstAsync(x => x.Id == id);
        }
    }
}
