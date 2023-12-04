using System.ComponentModel.DataAnnotations;

namespace CaitMazziniApp.Api.ViewModels.Exams
{
    public class ComplementaryExamViewModel
    {
        public int id { get; set; }

        public DateOnly date { get; set; }

        public virtual int patientId { get; set; }

        public string observations { get; set; } = string.Empty;
    }
}
