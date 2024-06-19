namespace CaitMazziniApp.Api.ViewModels.FirstAppointments
{
    public class FirstAppointmentViewModel
    {
        public int id { get; set; }

        public string mainIssues { get; set; }

        public string complementaryInfo { get; set; } = string.Empty;

        public string drugsInUse { get; set; }

        public int creatorId { get; set; }
    }
}
