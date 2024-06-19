using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreComplementaryExamRepository<TComplementaryExam> : EFCoreGenericRepository<TComplementaryExam, int>, IComplementaryExamRepository<TComplementaryExam>
        where TComplementaryExam : ComplementaryExam, new()
    {
        public EFCoreComplementaryExamRepository(CaitMazziniDbContext dbContext) : base(dbContext) { }

        public IList<TComplementaryExam> GetAllByPatient(int patientId)
        {
            return _dbContext.Set<TComplementaryExam>().Where(x => x.Patient.Id == patientId).ToList(); 
        }
    }
}
