using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreFirstNurseryAppointmentRepository : EFCoreGenericRepository<FirstNurseryAppointment, int>, IFirstNurseryAppointmentRepository
    {
        public EFCoreFirstNurseryAppointmentRepository(CaitMazziniDbContext dbContext) : base(dbContext) { }

        public async Task<FirstNurseryAppointment> GetByPatient(int patientId)
        {
            return await _dbContext.Set<FirstNurseryAppointment>().FirstAsync(x => x.Patient.Id == patientId);
        }
    }
}
