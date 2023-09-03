namespace Cait_Mazzini_App.DTOs
{
    public class DistrictDTO : BaseModelDTO
    {
        public string name { get; set; } = string.Empty;

        public int cityId { get; set; }
    }
}
