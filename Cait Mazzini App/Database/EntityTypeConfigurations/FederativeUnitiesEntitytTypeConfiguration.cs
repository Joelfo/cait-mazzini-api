using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cait_Mazzini_App.Database.EntityTypeConfigurations
{
    public class FederativeUnitiesEntitytTypeConfiguration : IEntityTypeConfiguration<FederativeUnity>
    {
        public void Configure(EntityTypeBuilder<FederativeUnity> builder)
        {
            builder.ToTable("federative_unities");
        }
    }
}
