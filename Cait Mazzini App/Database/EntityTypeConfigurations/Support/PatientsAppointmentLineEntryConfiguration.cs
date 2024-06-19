using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.Support;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Support
{
    public class PatientsAppointmentLineEntryConfiguration : IEntityTypeConfiguration<PatientsAppointmentLineEntry>
    {
        public void Configure(EntityTypeBuilder<PatientsAppointmentLineEntry> builder)
        {
            builder.ToTable("patients_appointment_line");
            builder.HasKey(x => x.PatientId);
            builder.HasOne(x => x.Patient).WithOne().IsRequired().HasForeignKey<PatientsAppointmentLineEntry>(x => x.PatientId);
        }
    }
}
