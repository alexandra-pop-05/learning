using System;
using System.Collections.Generic;

namespace GenericsProject.Models;

public partial class Event
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<UsersEvent> UsersEvents { get; set; } = new List<UsersEvent>();
}
