using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientLifeHabits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations
{
    public class LifeHabitsInfoConfiguration : IEntityTypeConfiguration<LifeHabitsInfo>
    {
        public void Configure(EntityTypeBuilder<LifeHabitsInfo> builder)
        {
            builder.ToTable("life_habits_info");
            builder
                .HasMany(x => x.PhysicalActivities)
                .WithMany(x => x.LifeHabitsInfos)
                .UsingEntity("life_habits_info_has_physical_activities",
                    x => x.HasOne(typeof(LifeHabitsInfo)).WithMany().HasForeignKey("lifeHabitsInfoId"),
                    x => x.HasOne(typeof(PhysicalActivity)).WithMany().HasForeignKey("physicalActivitiesId")
                );
            builder
                .HasMany(x => x.ContraceptiveMethods)
                .WithMany(x => x.LifeHabitsInfos)
                .UsingEntity("life_habits_info_has_contraceptive_methods",
                    x => x.HasOne(typeof(LifeHabitsInfo)).WithMany().HasForeignKey("lifeHabitsInfoId"),
                    x => x.HasOne(typeof(ContraceptiveMethod)).WithMany().HasForeignKey("contraceptiveMethodId")
                );
        }
    }
}
