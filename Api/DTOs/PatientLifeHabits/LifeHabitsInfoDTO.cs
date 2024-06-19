using CaitMazziniApp.Enums;
using CaitMazziniApp.Models.Core;
using CaitMazziniApp.Models.PatientLifeHabits;
using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.DTOs.PatientLifeHabits
{
    public class LifeHabitsInfoDTO
    {
        [Required]
        public int patientId { get; set; }

        [Required]
        public int mealsPerDay { get; set; }

        [Required]
        public int waterCupsPerDay { get; set; }

        [Required]
        public ESexualActivityLevel SexualActivityLevel { get; set; }
 
        public string eatingAndWaterObs { get; set; } = string.Empty;

        [Required]
        public string bladderEliminationsCharacteristic { get; set; } = string.Empty;

        [Required]
        public int bladderEliminationTimesPerDay { get; set; }

        [Required]
        public bool hasPainOnBladderEliminations { get; set; }

        [Required]
        public string intestinalEliminationsCharacteristic { get; set; } = string.Empty;

        [Required]
        public int intestinalEliminationTimesPerDay { get; set; }

        [Required]
        public bool hasPainOnIntestinalEliminations { get; set; }

        [Required]
        public bool isAlcoholUser { get; set; }

        public string alcoholQuantityObs { get; set; } = string.Empty;
        
        [Required]
        public bool isSmoker { get; set; }

        public int cigarretesPerDay { get; set; } = 0;

        [Required]
        public bool formerSmoker { get; set; }

        public string timeWithoutSmoking { get; set; } = "";

        [Required]
        public bool usesIllicitDrugs { get; set; }

        public string illicitDrugsUsingObs { get; set; } = "";

        [Required]
        public bool hasSatisfactorySleepingTime { get; set; }

        [Required]
        public int sleepingHoursPerNight { get; set; }

        public string sleepingTimeObs { get; set; } = "";

        public IList<int> physicalActivityIds { get; set; } = new List<int>();

        public string physicalActivitiesObservation { get; set; } = "";

        public int physicalActivityTimesPerWeek { get; set; }

        public string leisureObservation { get; set; } = "";

        public IList<int> contraceptiveMethodIds { get; set; } = new List<int>();

        public int sexualPartnersQuantity { get; set; }

        public bool hasPrEP { get; set; }

        public bool hasPEP { get; set; }
    }
}
