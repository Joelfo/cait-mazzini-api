using CaitMazziniApp.Models.Exams;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IComplementaryExamRepository<TComplementaryExam> : IGenericRepository<TComplementaryExam, int>
        where TComplementaryExam : ComplementaryExam, new()
    {
        IList<TComplementaryExam> GetAllByPatient(int patientId);
    }
}
