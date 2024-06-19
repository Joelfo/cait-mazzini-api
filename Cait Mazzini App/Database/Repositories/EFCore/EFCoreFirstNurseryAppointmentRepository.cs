using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreFirstNurseryAppointmentRepository : EFCoreGenericRepository<FirstNurseryAppointmentChart, int>, IFirstNurseryAppointmentRepository
    {
        public EFCoreFirstNurseryAppointmentRepository(CaitMazziniDbContext dbContext) : base(dbContext) { }

        public async Task<FirstNurseryAppointmentChart> GetByPatient(int patientId)
        {
            return await _dbContext.Set<FirstNurseryAppointmentChart>().FirstOrDefaultAsync(x => x.Patient.Id == patientId);
        }
    }
}
