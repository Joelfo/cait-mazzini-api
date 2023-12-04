namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class BiopsyExamViewModel : ComplementaryExamViewModel
    {
        public string analyzedTissue { get; set; }

        public string result { get; set; }
    }
}
