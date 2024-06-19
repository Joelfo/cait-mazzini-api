using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.FirstAppointments
{
    public class FirstAppointmentChartConfiguration : IEntityTypeConfiguration<FirstAppointmentChart>
    {
        public void Configure(EntityTypeBuilder<FirstAppointmentChart> builder)
        {
            builder.UseTpcMappingStrategy();
        }
    }
}
