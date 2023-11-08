﻿using CaitMazziniApp.Models.Base;

namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class DatedImmunization : BaseModel
    {
        public string Name { get; set; }

        public virtual IList<ClinicalHistory> ClinicalHistories { get; set; } = new List<ClinicalHistory>();
    }
}
