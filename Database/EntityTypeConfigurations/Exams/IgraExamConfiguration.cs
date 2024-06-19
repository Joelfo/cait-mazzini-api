using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class IgraExamConfiguration : IEntityTypeConfiguration<IgraExam>
    {
        public void Configure(EntityTypeBuilder<IgraExam> builder)
        {
            builder.ToTable("igra_exams");
        }
    }
}
