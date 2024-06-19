using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class ClinicalHistoryHasImmunizationConfiguration : IEntityTypeConfiguration<ClinicalHistoryHasImmunization>
    {
        public void Configure(EntityTypeBuilder<ClinicalHistoryHasImmunization> builder)
        {
            builder.ToTable("clinical_histories_has_immunizations");
        }
    }
}
