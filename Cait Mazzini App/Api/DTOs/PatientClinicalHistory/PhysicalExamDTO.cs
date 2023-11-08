using CaitMazziniApp.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class PhysicalExamDTO
    {
        [Required]
        public string generalAspect { get; set; }

        public string hygieneConditionsObs { get; set; } = String.Empty;

        public string headObs { get; set; } = String.Empty;

        public string neckObs { get; set; } = String.Empty;

        public string chestObs { get; set; } = String.Empty;

        public string abdomenObs { get; set; } = String.Empty;

        public string mmssMmiiObs { get; set; } = String.Empty;

        public string urinaryTrackObs { get; set; } = String.Empty;

        public string skinAndMucousObs { get; set; } = String.Empty;

        [Required]
        public int patientId { get; set; }
    }
}
