using Cait_Mazzini_App.Enums;
using Cait_Mazzini_App.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cait_Mazzini_App.Models
{
    public class Patient : BaseModel
    {
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

        public virtual Country BirthCountry { get; set; } = null!;

        public virtual HealthUnity? HealthUnity { get; set; }


    }
}
