using CaitMazziniApp.Models.PatientClinicalHistory;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IPhysicalExamRepository : IGenericRepository<PhysicalExam, int>
    {
        Task<IList<PhysicalExam>> GetByPatient(int patientId);
    }
}
