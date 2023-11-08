namespace CaitMazziniApp.Models.Exams
{
    public class BiopsyExam : ComplementaryExam
    {
        public Boolean PositiveResult { get; set; }

        public string Tissue { get; set; }

        public string Result { get; set; }
    }
}
