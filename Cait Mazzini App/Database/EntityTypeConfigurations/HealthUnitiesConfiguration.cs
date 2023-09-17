using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cait_Mazzini_App.Database.EntityTypeConfigurations
{
    public class HealthUnitiesConfiguration : IEntityTypeConfiguration<HealthUnity>
    {
        public void Configure(EntityTypeBuilder<HealthUnity> builder) 
        {
            builder.ToTable("health_unities");
        }
    }
}
