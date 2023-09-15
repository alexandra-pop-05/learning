using System;
using System.Collections.Generic;

namespace GenericsProject.Models;

public partial class KeyMilestone
{
    public int Id { get; set; }

    public string MilestoneName { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public int ProjectId { get; set; }

    public virtual Project Project { get; set; } = null!;
}
