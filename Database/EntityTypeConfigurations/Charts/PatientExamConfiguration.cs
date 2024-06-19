using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Charts
{
    public class PatientExamConfiguration
    {
        public void Configure(EntityTypeBuilder<PatientExam> builder)
        {
            builder.ToTable("patient_exam");
        }
    }
}
