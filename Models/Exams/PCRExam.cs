namespace CaitMazziniApp.Models.Exams
{
    public class PCRExam : ComplementaryExam
    {
        public Boolean IsPositiveResult { get; set; }


        public string Material { get; set; }

        public string Kit { get; set; }

        public string Method { get; set; }
    }
}
