using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class PCRExamViewModel : ComplementaryExamViewModel
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
