using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.PatientLifeHabits
{
    public class LifeHabitsInfo : BaseModel
    {
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        public int MealsPerDay { get; set; }

        public int WaterCupsPerDay { get; set; }

        public string EatingAndWaterObs { get; set; } = string.Empty;

        public string BladderEliminationsCharacteristic { get; set; } = string.Empty;

        public int BladderEliminationTimesPerDay { get; set; }

        public bool HasPainOnBladderEliminations { get; set; }

        public string IntestinalEliminationsCharacteristic { get; set; } = string.Empty;

        public int IntestinalEliminationTimesPerDay { get; set; }

        public bool HasPainOnIntestinalEliminations { get; set; }

        public bool isAlcoholUser { get; set; }

        public string AlcoholQuantityObs { get; set; } = string.Empty;

        public bool IsSmoker { get; set; }

        public int CigarretesPerDay { get; set; }

        public bool FormerSmoker { get; set; }

        public string TimeWithoutSmoking { get; set; }

        public bool UsesIllicitDrugs { get; set; }

        public string IllicitDrugsUsingObs { get; set; }

        public bool HasSatisfactorySleepingTime { get; set; }

        public int SleepingHoursPerNight { get; set; }

        public string SleepingTimeObs { get; set; }

        public virtual IList<PhysicalActivity> PhysicalActivities { get; set; } = new List<PhysicalActivity>();

        public string PhysicalActivitiesObservation { get; set; }

        public string LeisureObservation { get; set; }

        public virtual IList<ContraceptiveMethod> ContraceptiveMethods { get; set; } = new List<ContraceptiveMethod>();

        public ESexualActivityLevel SexualActivityLevel { get; set; }

        public int SexualPartnersQuantity { get; set; }

        public bool HasPrEP { get; set; }

        public bool HasPEP { get; set; }

    }
}
