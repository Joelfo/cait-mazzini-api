using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IFirstNurseryAppointmentRepository : IGenericRepository<FirstNurseryAppointmentChart, int>
    {
        public Task<FirstNurseryAppointmentChart> GetByPatient(int patientId);
    }
}
