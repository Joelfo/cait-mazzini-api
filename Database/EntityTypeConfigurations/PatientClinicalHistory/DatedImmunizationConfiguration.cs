using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class DatedImmunizationConfiguration : IEntityTypeConfiguration<DatedImmunization>
    {
        public void Configure(EntityTypeBuilder<DatedImmunization> builder)
        {
            builder.ToTable("dated_immunizations");
            builder
                .HasMany(x => x.ClinicalHistories)
                .WithMany(x => x.DatedImmunizations);
        }
    }
}
