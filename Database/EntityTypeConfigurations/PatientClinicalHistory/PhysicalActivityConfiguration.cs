using CaitMazziniApp.Models.PatientLifeHabits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations
{
    public class PhysicalActivityConfiguration : IEntityTypeConfiguration<PhysicalActivity>
    {
        public void Configure(EntityTypeBuilder<PhysicalActivity> builder) 
        {
            builder.ToTable("physical_activities");
            builder.HasMany(x => x.LifeHabitsInfos)
                .WithMany(x => x.PhysicalActivities)
                .UsingEntity("life_habits_info_has_physical_activities",
                    x => x.HasOne(typeof(LifeHabitsInfo)).WithMany().HasForeignKey("lifeHabitsInfoId"),
                    x => x.HasOne(typeof(PhysicalActivity)).WithMany().HasForeignKey("physicalActivitiesId")
                    );
        }
    }
}
