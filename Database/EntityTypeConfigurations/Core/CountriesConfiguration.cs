using CaitMazziniApp.Models.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Core
{
    public class CountriesConfiguration
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("countries");
        }
    }
}
