using CaitMazziniApp.Models.Charts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Charts
{
    public class VitalSignsMeasurementsConfiguration : IEntityTypeConfiguration<VitalSignsMeasurement>
    {
        public void Configure(EntityTypeBuilder<VitalSignsMeasurement> builder)
        {
            builder.ToTable("vital_signs_measurements");
        }
    }
}
