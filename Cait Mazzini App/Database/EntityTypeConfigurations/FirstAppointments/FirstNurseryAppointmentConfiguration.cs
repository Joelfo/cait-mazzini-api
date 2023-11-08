using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.FirstAppointments
{
    public class FirstNurseryAppointmentConfiguration : IEntityTypeConfiguration<FirstNurseryAppointment>
    {
        public void Configure(EntityTypeBuilder<FirstNurseryAppointment> builder)
        {
            builder
                .UseTpcMappingStrategy()
                .ToTable("first_nursery_appointment");
        }
    }
}
