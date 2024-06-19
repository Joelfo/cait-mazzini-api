using CaitMazziniApp.Database.EntityTypeConfigurations;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientClinicalHistory;
using Microsoft.EntityFrameworkCore;

namespace CaitMazziniApp.Database.Contexts
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
