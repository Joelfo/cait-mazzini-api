using CaitMazziniApp.Enums;

namespace CaitMazziniApp.Models.Exams
{
    public class BaarExam : ComplementaryExam
    {
        public int MonthNumber { get; set; }

        public int SampleNumber { get; set; }

        public Boolean IsMaterialSputum { get; set; }

        public string? OtherMaterial { get; set; }

        public ESputumAspect SputumAspect { get; set; }

        public EBaarResult Result { get; set; }
    }
}
