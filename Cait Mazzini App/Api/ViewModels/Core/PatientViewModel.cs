using CaitMazziniApp.DTOs.ValidationAttributes;
using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.ViewModels
{
    public class PatientViewModel
    {
        public int id { get; set; }

        public string name { get; set; } = string.Empty;

        public string recordCode { get; set; } = string.Empty;

        public string susCard { get; set; }

        public string rg { get; set; }

        public string cpf { get; set; }

        public DateOnly admissionDate { get; set; }

        public EPatientType type { get; set; }

        public EArrival arrivalType { get; set; }

        public string telephone1 { get; set; }

        public string telephone2 { get; set; }

        public string cep { get; set; }

        public bool isPregnant { get; set; }

        public DateOnly birthDate { get; set; }

        public string motherName { get; set; }

        public string addressStreet { get; set; }

        public int addressNumber { get; set; }

        public string? addressComplement { get; set; }

        public ESpecialPopulation specialPopulationType { get; set; }

        public string? otherSpacialPopulation { get; set; }

        public EBiologicalGender biologicalGender { get; set; }

        public int birthplaceId { get; set; }

        public int districtId { get; set; }

        public int birthCountryId { get; set; }

        public int? healthUnitytId { get; set; } = null;
    }
}
