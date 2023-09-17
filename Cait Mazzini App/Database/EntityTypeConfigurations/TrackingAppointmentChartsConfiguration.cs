using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cait_Mazzini_App.Database.EntityTypeConfigurations
{
    public class TrackingAppointmentChartsConfiguration : IEntityTypeConfiguration<TrackingAppointmentChart>
    {
        public void Configure(EntityTypeBuilder<TrackingAppointmentChart> builder)
        {
            builder.ToTable("tracking_appointment_charts");
        }
    }
}
