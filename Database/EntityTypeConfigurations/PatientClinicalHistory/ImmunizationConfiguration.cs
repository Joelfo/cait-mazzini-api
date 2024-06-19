using CaitMazziniApp.Models.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientLifeHabits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class ImmunizationConfiguration: IEntityTypeConfiguration<Immunization>
    {
        public void Configure(EntityTypeBuilder<Immunization> builder)
        {
            builder.ToTable("immunizations");
            builder
                .HasMany(x => x.ClinicalHistories)
                .WithMany(x => x.Immunizations)
                .UsingEntity<ClinicalHistoryHasImmunization>();
        }
    }
}
