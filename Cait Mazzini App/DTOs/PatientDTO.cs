using Cait_Mazzini_App.Enums;

namespace Cait_Mazzini_App.DTOs
{
    public class PatientDTO : BaseModelDTO
    {
        public string name { get; set; } = string.Empty;

        public string recordCode { get; set; } = string.Empty;

        public string susCard { get; set; } = string.Empty;

        public string rg { get; set; } = string.Empty;

        public string cpf { get; set; } = string.Empty;

        public DateOnly admissionDate { get; set; }

        public EPatientType type { get; set; }

        public EArrival arrivalType { get; set; }

        public string telephone1 { get; set; } = string.Empty;

        public string telephone2 { get; set; } = string.Empty;

        public string cep { get; set; } = string.Empty;

        public bool isPregnant { get; set; }

        public DateOnly birthDate { get; set; }

        public string motherName { get; set; } = string.Empty;

        public string street { get; set; } = string.Empty;

        public int number { get; set; }

        public ESpecialPopulation specialPopulationType { get; set; } 

        public string otherSpacialPopulation { get; set; } = string.Empty;

        public EBiologicalGender biologicalGender { get; set; }

        public string birthPlace { get; set; } = string.Empty;

        public int districtId { get; set; }

        public int birthCountryId { get; set; }

        public int? healthUnitytId { get; set; } = null;
    }
}
