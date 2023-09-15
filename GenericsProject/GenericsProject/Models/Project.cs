using System;
using System.Collections.Generic;

namespace GenericsProject.Models;

public partial class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public int TeamManagerId { get; set; }

    public int ProjectManagerId { get; set; }

    public string ProjectStatus { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Client { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<KeyMilestone> KeyMilestones { get; set; } = new List<KeyMilestone>();

    public virtual User ProjectManager { get; set; } = null!;

    public virtual ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();

    public virtual User TeamManager { get; set; } = null!;
}
