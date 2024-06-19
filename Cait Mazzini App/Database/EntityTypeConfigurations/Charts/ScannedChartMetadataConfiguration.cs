using CaitMazziniApp.Models.Charts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Charts
{
    public class ScannedChartMetadataConfiguration : IEntityTypeConfiguration<ScannedChartMetadata>
    {
        public void Configure(EntityTypeBuilder<ScannedChartMetadata> builder)
        {
            builder.ToTable("scanned_charts_metadata");
            builder.Property(x => x.FilePath).HasColumnName("file_path");
            builder.Property<int>("PatientId").HasColumnName("patient_id").IsRequired();
        }
    }
}