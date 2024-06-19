using CaitMazziniApp.Mapper.Profiles.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class OtherExamConfiguration : IEntityTypeConfiguration<OtherExam>
    {
        public void Configure(EntityTypeBuilder<OtherExam> builder) {
            builder.ToTable("other_exams");
        }
    }
}
