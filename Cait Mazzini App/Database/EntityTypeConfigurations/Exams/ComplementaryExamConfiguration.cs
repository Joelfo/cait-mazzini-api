using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class ComplementaryExamConfiguration : IEntityTypeConfiguration<ComplementaryExam>
    {
        public void Configure(EntityTypeBuilder<ComplementaryExam> builder)
        {
            builder.ToTable("complementary_exams");
            builder.UseTptMappingStrategy();
            builder.HasOne(x => x.Patient)
                .WithMany()
                .HasForeignKey("patient_id");
            builder.HasMany(x => x.ExamFiles)
                .WithOne(x => x.ComplementaryExam)
                .HasForeignKey("complementary_exam_id");
        }
    }
}
