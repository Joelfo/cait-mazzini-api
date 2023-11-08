﻿using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.PatientClinicalHistory
{
    public class PhysicalExam : BaseModel
    {
        public string GeneralAspect { get; set; } = String.Empty;

        public string HygieneConditionsObs { get; set; } = String.Empty;

        public string HeadObs { get; set; } = String.Empty;

        public string NeckObs { get; set; } = String.Empty;

        public string ChestObs { get; set; } = String.Empty;

        public string AbdomenObs { get; set; } = String.Empty;

        public string MmssMmiiObs { get; set; } = String.Empty;

        public string UrinaryTrackObs { get; set; } = String.Empty;

        public string SkinAndMucousObs { get; set; } = String.Empty;

        public virtual Patient Patient { get; set; }

        public int PatientId { get; set; }
    }
}
