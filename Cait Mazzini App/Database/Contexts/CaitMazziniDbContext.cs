using Cait_Mazzini_App.Database.EntityTypeConfigurations;
using Cait_Mazzini_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Cait_Mazzini_App.Database.Contexts
{
    public class CaitMazziniDbContext : DbContext
    {
        public CaitMazziniDbContext(DbContextOptions<CaitMazziniDbContext> options)
            : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Model mapping configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Patient).Assembly);
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<HealthUnity> HealthUnities { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<VitalSignsMeasurement> VitalSignsMeasurements { get; set; }
        public DbSet<TrackingAppointmentChart> TrackingAppointmentCharts { get; set; }

    }
}
