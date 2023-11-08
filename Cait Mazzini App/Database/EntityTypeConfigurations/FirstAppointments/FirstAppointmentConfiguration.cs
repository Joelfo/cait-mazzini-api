using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.FirstAppointments
{
    public class FirstAppointmentConfiguration : IEntityTypeConfiguration<FirstAppointment>
    {
        public void Configure(EntityTypeBuilder<FirstAppointment> builder)
        {
            builder
                .UseTpcMappingStrategy();
        }
    }
}
