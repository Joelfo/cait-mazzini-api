namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class IgraExamViewModel : ComplementaryExamViewModel
    {
        public Boolean isPositiveResult
        {
            get; set;
        }

        public string material { get; set; }

        public string kit { get; set; }

        public string method { get; set; }
    }
}
