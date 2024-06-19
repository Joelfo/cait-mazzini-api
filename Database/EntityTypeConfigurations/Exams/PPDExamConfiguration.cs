using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class PPDExamConfiguration : IEntityTypeConfiguration<PPDExam>
    {
        public void Configure(EntityTypeBuilder<PPDExam> builder)
        {
            builder.ToTable("ppd_exams");
            builder.Property(x => x.IsReactiveResult).HasColumnName("is_reactive_result");
        }
    }
}
