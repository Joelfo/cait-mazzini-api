using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class ToraxXRayExamConfiguration : IEntityTypeConfiguration<ToraxXRayExam>
    {
        public void Configure(EntityTypeBuilder<ToraxXRayExam> builder)
        {
            builder.ToTable("torax_x_ray_exams");
            builder.Property(x => x.xRayResult).HasColumnName("x_ray_result");
        }
    }
}
