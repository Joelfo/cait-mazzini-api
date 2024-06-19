using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class PCRExamConfiguration : IEntityTypeConfiguration<PCRExam>
    {
        public void Configure(EntityTypeBuilder<PCRExam> builder)
        {
            builder.ToTable("pcr_exams");
            builder.Property(x => x.IsPositiveResult).HasColumnName("is_positive_result");
        }
    }
}
