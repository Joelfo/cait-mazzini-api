using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class BaarExamConfiguration : IEntityTypeConfiguration<BaarExam>
    {
        public void Configure(EntityTypeBuilder<BaarExam> builder)
        {
            builder.ToTable("baar_exams");
        }
    }
}
