using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class BiopsyExamConfiguration : IEntityTypeConfiguration<BiopsyExam>
    {
        public void Configure(EntityTypeBuilder<BiopsyExam> builder)
        {
            builder.ToTable("biopsy_exams");
            //builder.HasOne<ComplementaryExam>().WithOne().HasForeignKey<BiopsyExam>("complementary_exam_id").HasConstraintName("biopsy_exams_complementary_exams");
            builder.Property(x => x.AnalyzedTissue).HasColumnName("analyzed_tissue");
            builder.Property(x => x.IsPositiveResult).HasColumnName("is_positive_result");
        }
    }
}
