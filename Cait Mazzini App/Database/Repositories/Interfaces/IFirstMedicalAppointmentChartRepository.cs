using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IFirstMedicalAppointmentChartRepository : IGenericRepository<FirstMedicalAppointmentChart, int>
    {
        public Task<FirstMedicalAppointmentChart> GetByPatient(int patientId);
    }
}
