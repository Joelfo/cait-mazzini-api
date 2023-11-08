using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class PhysicalExamConfiguration : IEntityTypeConfiguration<PhysicalExam>
    {
        public void Configure(EntityTypeBuilder<PhysicalExam> builder) 
        {
            builder.ToTable("physical_exams");
        }
    }
}
