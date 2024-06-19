using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.PatientClinicalHistory
{
    public class DeseaseConfiguration : IEntityTypeConfiguration<Desease>
    {
        public void Configure(EntityTypeBuilder<Desease> builder)
        {
            builder.ToTable("deseases");
            builder
                .HasMany(x => x.ClinicalHistories)
                .WithMany(x => x.PreviousDeseases)
                .UsingEntity<ClinicalHistoryHasPreviousDesease>();
        }
    }
}
