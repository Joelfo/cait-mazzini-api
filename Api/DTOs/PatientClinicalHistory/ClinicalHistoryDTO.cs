using CaitMazziniApp.Models.PatientClinicalHistory;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class ClinicalHistoryDTO
    {

        public IList<int> previousDeseaseIds { get; set; } = new List<int>();

        public string? otherPreviousDeseases { get; set; }

        [Required]
        public Boolean isAlergic { get; set; }

        public string? alergyObs { get; set; } = string.Empty;

        [Required]
        public Boolean hasPreviousSurgery { get; set; }

        public string? previousSurgeryObs { get; set; } = string.Empty;

        [Required]
        public Boolean hasPreviousHospitalizations { get; set; }

        public string? previousHospitalizationsObs { get; set; } = string.Empty;

        public string? timeFromLastHospitalization { get; set; } = string.Empty;

        public IList<int> immunizationIds { get; set; } = new List<int>();

        public IList<ClinicalHistoryHasDatedImmunizationDTO> datedImmunizationIds { get; set; } = new List<ClinicalHistoryHasDatedImmunizationDTO>();

        public string? otherImmunizations { get; set; } = string.Empty;

        public int patientId { get; set; }
    }
}
