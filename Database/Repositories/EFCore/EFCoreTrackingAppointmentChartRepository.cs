using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Database.Repositories.Interfaces;
using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Charts.Utils;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Repositories.EFCore
{
    public class EFCoreTrackingAppointmentChartRepository : EFCoreGenericRepository<TrackingAppointmentChart, int>, ITrackingAppointmentChartRepository
    {
        public EFCoreTrackingAppointmentChartRepository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
                
        }

        public virtual async Task<IList<TrackingAppointmentChart>> AllByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip = null, int? take = null)
        {
            var query = _dbContext.Set<TrackingAppointmentChart>().Where(x => x.Patient.Id == patientId).Where(x => x.Type == type);

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            return await query.ToListAsync();
            
        }

        public virtual async Task<IList<TrackingAppointmentChartBasicInfo>> AllBasicInfoByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip = null, int? take = null)
        {
            var query = _dbContext.Set<TrackingAppointmentChart>()
                .Where(x => x.Patient.Id == patientId)
                .Where(x => x.Type == type);
                
            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            return await query
                .Select(x => new TrackingAppointmentChartBasicInfo { Id = x.Id, Date = x.Date })
                .ToListAsync();
        }


        public virtual async Task<IList<TrackingAppointmentChartBasicInfo>> AllBasicInfoByPatient(int patientId, int? skip = null, int? take = null)
        {
            var query = _dbContext.Set<TrackingAppointmentChart>()
                .Where(x => x.Patient.Id == patientId);

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            return await query
                .Select(x => new TrackingAppointmentChartBasicInfo { Id = x.Id, Date = x.Date, Type = x.Type })
                .ToListAsync();
        }
    }
}
