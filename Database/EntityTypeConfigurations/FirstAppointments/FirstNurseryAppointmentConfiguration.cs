using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.FirstAppointments
{
    public class FirstNurseryAppointmentConfiguration : IEntityTypeConfiguration<FirstNurseryAppointmentChart>
    {
        public void Configure(EntityTypeBuilder<FirstNurseryAppointmentChart> builder)
        {
            builder
                .ToTable("first_nursery_appointment_charts");
        }
    }
}
