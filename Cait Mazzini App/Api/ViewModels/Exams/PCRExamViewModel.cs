using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class PCRExamViewModel : ComplementaryExamViewModel
    {
        public Boolean isPositiveResult
        {
            get; set;
        }
    }
}
