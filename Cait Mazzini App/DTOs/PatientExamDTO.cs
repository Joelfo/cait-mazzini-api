﻿namespace Cait_Mazzini_App.DTOs
{
    public class PatientExamDTO
    {
        public DateOnly date { get; set; }

        public int patientId { get; set; }

        public IFormFile examFile { get; set; } = null!;
    }
}
