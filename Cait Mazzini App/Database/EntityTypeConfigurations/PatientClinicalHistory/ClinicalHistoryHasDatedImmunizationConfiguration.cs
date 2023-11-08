using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class ClinicalHistoryHasDatedImmunizationConfiguration : IEntityTypeConfiguration<ClinicalHistoryHasDatedImmunization>
    {
        public void Configure(EntityTypeBuilder<ClinicalHistoryHasDatedImmunization> builder)
        {
            builder.ToTable("clinical_histories_has_dated_immunizations");
        }
    }
}
