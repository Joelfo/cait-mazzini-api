﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace CaitMazziniApp.Api.DTOs.FirstAppointments
{
    public class FirstAppointmentDTO
    {
        [Required]
        public string mainIssues { get; set; }

        public string? drugsInUse { get; set; }

        public string? complementaryInfo { get; set; }

        [Required]
        public int patientId { get; set; }

        [Required]
        public string conduct { get; set; }

        [Required]
        public int creatorId { get; set; }
    }
}
