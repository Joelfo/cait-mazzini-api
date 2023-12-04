using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class CulturesExamConfiguration : IEntityTypeConfiguration<CulturesExam>
    {
        public void Configure(EntityTypeBuilder<CulturesExam> builder)
        {
            builder
                .ToTable("cultures_exams");
            builder.Property(x => x.IsPositiveResult).HasColumnName("is_positive_result");
;
        }
    }
}
