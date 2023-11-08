using CaitMazziniApp.Models.Charts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Charts
{
    public class TrackingAppointmentChartsConfiguration : IEntityTypeConfiguration<TrackingAppointmentChart>
    {
        public void Configure(EntityTypeBuilder<TrackingAppointmentChart> builder)
        {
            builder.ToTable("tracking_appointment_charts");
        }
    }
}
