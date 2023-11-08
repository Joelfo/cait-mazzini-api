using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientLifeHabits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations
{
    public class ContraceptiveMethodsConfiguration : IEntityTypeConfiguration<ContraceptiveMethod>
    {
        public void Configure(EntityTypeBuilder<ContraceptiveMethod> builder)
        {
            builder.ToTable("contraceptive_methods");
            builder
                .HasMany(x => x.LifeHabitsInfos)
                .WithMany(x => x.ContraceptiveMethods)
                .UsingEntity("life_habits_info_has_contraceptive_methods",
                    x => x.HasOne(typeof(LifeHabitsInfo)).WithMany().HasForeignKey("lifeHabitsInfoId"),
                    x => x.HasOne(typeof(ContraceptiveMethod)).WithMany().HasForeignKey("contraceptiveMethodId")
                ); ;
        }
    }
}
