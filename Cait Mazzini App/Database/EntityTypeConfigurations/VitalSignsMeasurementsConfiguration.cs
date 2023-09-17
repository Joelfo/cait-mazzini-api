using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cait_Mazzini_App.Database.EntityTypeConfigurations
{
    public class VitalSignsMeasurementsConfiguration : IEntityTypeConfiguration<VitalSignsMeasurement>
    {
        public void Configure(EntityTypeBuilder<VitalSignsMeasurement> builder)
        {
            builder.ToTable("vital_signs_measurements");
        }
    }
}
