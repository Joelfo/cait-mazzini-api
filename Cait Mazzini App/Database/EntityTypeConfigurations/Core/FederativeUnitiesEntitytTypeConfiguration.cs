using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations
{
    public class FederativeUnitiesEntitytTypeConfiguration : IEntityTypeConfiguration<FederativeUnity>
    {
        public void Configure(EntityTypeBuilder<FederativeUnity> builder)
        {
            builder.ToTable("federative_unities");
        }
    }
}
