

namespace EFCoreSeedAndMigrations.Models
{
    public class MyEvent
    {
        public int MyEventId { get; set; }
        public virtual string Name { get; set; }
        //public virtual string? Description { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
