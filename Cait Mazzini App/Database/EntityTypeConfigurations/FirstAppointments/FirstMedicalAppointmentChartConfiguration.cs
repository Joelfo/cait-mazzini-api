using CaitMazziniApp.Models.FirstAppointments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.FirstAppointments
{
    public class FirstMedicalAppointmentChartConfiguration : IEntityTypeConfiguration<FirstMedicalAppointmentChart>
    {
        public void Configure(EntityTypeBuilder<FirstMedicalAppointmentChart> builder)
        {
            builder.ToTable("first_medical_appointment_charts");
        }
    }
}
