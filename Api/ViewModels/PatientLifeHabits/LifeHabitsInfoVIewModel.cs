namespace CaitMazziniApp.Api.ViewModels.PatientLifeHabits
{
    public class LifeHabitsInfoVIewModel
    {
        public int id { get; set; }

        public int patientId { get; set; }

        public int mealsPerDay { get; set; }

        public int waterCupsPerDay { get; set; }

        public string eatingAndWaterObs { get; set; } = string.Empty;

        public string bladderEliminationsCharacteristic { get; set; } = string.Empty;

        public int bladderEliminationTimesPerDay { get; set; }

        public bool hasPainOnBladderEliminations { get; set; }

        public string intestinalEliminationsCharacteristic { get; set; } = string.Empty;

        public string intestinalEliminationTimesPerDay { get; set; } = string.Empty;

        public string hasPainOnIntestinalEliminations { get; set; } = string.Empty;

        public bool isAlcoholUser { get; set; }

        public string alcoholQuantityObs { get; set; } = string.Empty;

        public bool isSmoker { get; set; }

        public int cigarretesPerDay { get; set; }

        public bool formerSmoker { get; set; }

        public string timeWithoutSmoking { get; set; }

        public bool usesIllicitDrugs { get; set; }

        public string illicitDrugsUsingObs { get; set; }

        public bool hasSatisfatorySleepingTime { get; set; }

        public int sleepingHoursPerNight { get; set; }

        public string sleepingTimeObs { get; set; }

        public IList<int> physicalActivityIds { get; set; } = new List<int>();

        public int physicalActivityTimesPerWeek { get; set; } = 0;

        public string physicalActivitiesObservation { get; set; }

        public string leisureObservation { get; set; }

        public IList<int> contraceptiveMethodIds { get; set; } = new List<int>();

        public int sexualPartnersQuantity { get; set; }


    }
}
