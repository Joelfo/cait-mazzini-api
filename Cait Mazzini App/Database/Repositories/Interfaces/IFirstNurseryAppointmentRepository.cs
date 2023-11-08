using CaitMazziniApp.Models.FirstAppointments;

namespace CaitMazziniApp.Database.Repositories.Interfaces
{
    public interface IFirstNurseryAppointmentRepository : IGenericRepository<FirstNurseryAppointment, int>
    {
        public Task<FirstNurseryAppointment> GetByPatient(int patientId);
    }
}
