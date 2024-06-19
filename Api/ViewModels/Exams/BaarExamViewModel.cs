using CaitMazziniApp.Enums;

namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class BaarExamViewModel : ComplementaryExamViewModel
    {
        public int monthNumber { get; set; }

        public int sampleNumber { get; set; }

        public Boolean isMaterialSputum { get; set; }

        public string? otherMaterial { get; set; }

        public ESputumAspect sputumAspect { get; set; }

        public EBaarResult result { get; set; }
    }
}
