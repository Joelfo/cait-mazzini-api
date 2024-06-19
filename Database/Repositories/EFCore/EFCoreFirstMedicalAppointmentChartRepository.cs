using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreFirstMedicalAppointmentChartRepository : EFCoreGenericRepository<FirstMedicalAppointmentChart, int>, IFirstMedicalAppointmentChartRepository
    {
        public EFCoreFirstMedicalAppointmentChartRepository(CaitMazziniDbContext context) : base(context)
        {
            
        }

        public async Task<FirstMedicalAppointmentChart> GetByPatient(int patientId)
        {
            return await _dbContext.Set<FirstMedicalAppointmentChart>().FirstOrDefaultAsync(x => x.Patient.Id == patientId);
        }
    }
}
