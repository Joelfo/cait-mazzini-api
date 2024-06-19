namespace CaitMazziniApp.Models.Core
{
    public class PatientRelationshipsInfo : PatientBasicInfo
    {
        public Boolean HasClinicalHistory { get; set; }
        public Boolean HasLifeHabitsInfo { get; set; }
        public Boolean HasScannedChart { get; set; }

    }
}
