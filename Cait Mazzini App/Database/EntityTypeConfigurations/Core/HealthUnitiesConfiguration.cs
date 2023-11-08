using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations
{
    public class HealthUnitiesConfiguration : IEntityTypeConfiguration<HealthUnity>
    {
        public void Configure(EntityTypeBuilder<HealthUnity> builder) 
        {
            builder.ToTable("health_unities");
        }
    }
}
