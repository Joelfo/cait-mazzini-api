namespace CaitMazziniApp.Models.Exams
{
    public class BiopsyExam : ComplementaryExam
    {

        public Boolean IsPositiveResult { get; set; }

        public string AnalyzedTissue { get; set; }

        public string Result { get; set; }
    }
}
