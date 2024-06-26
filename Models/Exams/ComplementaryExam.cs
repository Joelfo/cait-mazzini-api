﻿using CaitMazziniApp.Enums;
using CaitMazziniApp.Mapper.Profiles.Exams;
using CaitMazziniApp.Models.Base;
using CaitMazziniApp.Models.Core;

namespace CaitMazziniApp.Models.Exams
{
    public class ComplementaryExam : IId
    {
        public int Id { get; set; }

        public virtual IList<ExamFileMetadata> ExamFiles { get; set; } = new List<ExamFileMetadata>();

        public DateOnly Date { get; set; }

        public virtual Patient Patient { get; set; }

        public string? Observations { get; set; }
    }
}
