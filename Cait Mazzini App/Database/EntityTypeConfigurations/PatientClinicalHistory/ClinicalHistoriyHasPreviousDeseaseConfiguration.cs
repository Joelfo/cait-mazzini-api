using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class ClinicalHistoriyHasPreviousDeseaseConfiguration : IEntityTypeConfiguration<ClinicalHistoryHasPreviousDesease>
    {
        public void Configure(EntityTypeBuilder<ClinicalHistoryHasPreviousDesease> builder)
        {
            builder.ToTable("clinical_histories_has_previous_deseases");
        }
    }
}
