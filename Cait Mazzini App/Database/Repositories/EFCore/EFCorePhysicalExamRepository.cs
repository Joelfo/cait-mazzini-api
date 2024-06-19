using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCorePhysicalExamRepository : EFCoreGenericRepository<PhysicalExam, int>, IPhysicalExamRepository
    {
        public EFCorePhysicalExamRepository(CaitMazziniDbContext context) : base(context)
        {
            
        }

        public async Task<IList<PhysicalExam>> GetByPatient(int patientId)
        {
            return await _dbContext.Set<PhysicalExam>().Where(x => x.PatientId == patientId).ToListAsync();
        }

    }
}
