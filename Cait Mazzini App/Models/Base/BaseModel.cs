namespace CaitMazziniApp.Models.Base
{
    public abstract class BaseModel : IId
    {
        public int Id { get; set; }
    }
}
