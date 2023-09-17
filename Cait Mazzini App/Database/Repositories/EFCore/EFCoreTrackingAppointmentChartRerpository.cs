using Cait_Mazzini_App.Database.Contexts;
using Cait_Mazzini_App.Database.Repositories.Interfaces;
using Cait_Mazzini_App.Enums;
using Cait_Mazzini_App.Models;
using Cait_Mazzini_App.Models.Utils;
using Microsoft.EntityFrameworkCore;

namespace Cait_Mazzini_App.Database.Repositories.EFCore
{
    public class EFCoreTrackingAppointmentChartRerpository : EFCoreGenericRepository<TrackingAppointmentChart, int>, ITrackingAppointmentChartRepository
    {
        public EFCoreTrackingAppointmentChartRerpository(CaitMazziniDbContext dbContext) : base(dbContext)
        {
                
        }

        public virtual IList<TrackingAppointmentChart> AllByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip = null, int? take = null)
        {
            var query = _dbContext.Set<TrackingAppointmentChart>().Where(x => x.Patient.Id == patientId).Where(x => x.Type == type);

            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            return query.ToList();
            
        }

        public virtual IList<TrackingAppointmentChartBasicInfo> AllBasicInfoByPatientAndType(int patientId, ETrackingAppointmentChartType type, int? skip = null, int? take = null)
        {
            var query = _dbContext.Set<TrackingAppointmentChart>()
                .Where(x => x.Patient.Id == patientId)
                .Where(x => x.Type == type);
                
            if (skip.HasValue && take.HasValue)
            {
                query = query.Skip(skip.Value).Take(take.Value);
            }

            return query
                .Select(x => new TrackingAppointmentChartBasicInfo { Id = x.Id, Date = x.Date })
                .ToList();
        }
    }
}
