using CaitMazziniApp.DTOs.ValidationAttributes;
using CaitMazziniApp.Enums;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.Core.Patient
{
    public class PatientDTO
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string recordCode { get; set; }

        [Required, Cns]
        public string susCard { get; set; }

        [Required]
        public string rg { get; set; }

        [Required, Cpf]
        public string cpf { get; set; }

        [Required]
        public DateOnly admissionDate { get; set; }

        [Required]
        public EPatientType? type { get; set; }

        [Required]
        public EArrival? arrivalType { get; set; }

        [Required]
        public string telephone1 { get; set; }

        public string? telephone2 { get; set; }

        [Required]
        public string cep { get; set; }

        [Required]
        public bool isPregnant { get; set; }

        [Required]
        public DateOnly birthDate { get; set; }

        [Required]
        public string motherName { get; set; }

        [Required]
        public string addressStreet { get; set; }

        public int? addressNumber { get; set; }

        public string? addressComplement { get; set; }

        [Required]
        public ESpecialPopulation specialPopulationType { get; set; }

        public string? otherSpacialPopulation { get; set; }

        [Required]
        public EBiologicalGender biologicalGender { get; set; }

        [Required]
        public int? birthplaceId { get; set; }

        [Required]
        public int? districtId { get; set; }

        public int? healthUnityId { get; set; } = null;
    }
}
