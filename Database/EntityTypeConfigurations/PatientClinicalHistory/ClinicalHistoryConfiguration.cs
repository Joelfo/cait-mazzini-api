using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Core
{
    public class ClinicalHistoryConfiguration : IEntityTypeConfiguration<ClinicalHistory>
    {
        public void Configure(EntityTypeBuilder<ClinicalHistory> builder)
        {
            builder.ToTable("clinical_histories");
            builder.HasMany(x => x.PreviousDeseases).WithMany(x => x.ClinicalHistories)
                .UsingEntity<ClinicalHistoryHasPreviousDesease>();
            builder.HasMany(x => x.Immunizations).WithMany(x => x.ClinicalHistories)
                .UsingEntity<ClinicalHistoryHasImmunization>();
            builder.HasMany(x => x.DatedImmunizations).WithMany(x => x.ClinicalHistories)
                .UsingEntity<ClinicalHistoryHasDatedImmunization>();
        }
    }
}
