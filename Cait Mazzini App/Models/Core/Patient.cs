using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Charts;
using CaitMazziniApp.Models.PatientClinicalHistory;
using CaitMazziniApp.Models.PatientLifeHabits;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaitMazziniApp.Models.Core
{
    public class Patient : IId
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string RecordCode { get; set; } = string.Empty;

        public string SusCard { get; set; } = string.Empty;

        public string Rg { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public DateOnly AdmissionDate { get; set; }

        public EPatientType Type { get; set; }

        public EArrival ArrivalType { get; set; }

        public string Telephone1 { get; set; } = string.Empty;

        public string? Telephone2 { get; set; } = string.Empty;

        public string Cep { get; set; } = string.Empty;

        public bool IsPregnant { get; set; }

        public DateOnly BirthDate { get; set; }

        public string MotherName { get; set; } = string.Empty;

        public string AddressStreet { get; set; } = string.Empty;

        public int? AddressNumber { get; set; }

        public string? AddressComplement { get; set; }

        public ESpecialPopulation SpecialPopulationType { get; set; }

        public string? OtherSpecialPopulation { get; set; } = string.Empty;

        public EBiologicalGender BiologicalGender { get; set; }

        public virtual District District { get; set; } = null!;

        public virtual FederativeUnity Birthplace { get; set; } = null!;

        public virtual HealthUnity? HealthUnity { get; set; }

        public virtual ClinicalHistory? ClinicalHistory { get; set; }
    
        public virtual LifeHabitsInfo? LifeHabitsInfo { get; set; }

        public virtual ScannedChartMetadata? ScannedChartMetadata { get; set; }
    }
}
