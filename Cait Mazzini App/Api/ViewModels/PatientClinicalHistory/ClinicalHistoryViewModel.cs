namespace CaitMazziniApp.Api.DTOs.PatientClinicalHistory
{
    public class ClinicalHistoryViewModel
    {
        public int id { get; set; }

        public IList<int> previousDeseaseIds { get; set; } = new List<int>();

        public string otherPreviousDeseases { get; set; }

        public Boolean isAlergic { get; set; }

        public string alergyObs { get; set; } = string.Empty;

        public Boolean hasPreviousSurgery { get; set; }

        public string previousSurgeryObs { get; set; } = string.Empty;

        public Boolean hasPreviousHospitalizations { get; set; }

        public string previousHospitalizationsObs { get; set; } = string.Empty;

        public string timeFromLastHospitalization { get; set; } = string.Empty;

        public IList<int> immunizationIds { get; set; } = new List<int>();

        public string otherImmunizations { get; set; } = string.Empty;

        public int patientId { get; set; }
    }
}
