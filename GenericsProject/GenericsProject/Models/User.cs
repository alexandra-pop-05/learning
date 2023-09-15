using System;
using System.Collections.Generic;

namespace GenericsProject.Models;

public partial class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Birthday { get; set; }

    public string Role { get; set; } = null!;

    public string Levels { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string City { get; set; } = null!;

    public DateTime JoinedAt { get; set; }

    public int FreeDaysLeft { get; set; }

    public byte[]? Photo { get; set; }

    public virtual ICollection<ProjectMember> ProjectMembers { get; set; } = new List<ProjectMember>();

    public virtual ICollection<Project> ProjectProjectManagers { get; set; } = new List<Project>();

    public virtual ICollection<Project> ProjectTeamManagers { get; set; } = new List<Project>();

    public virtual ICollection<Review> ReviewUploadedBies { get; set; } = new List<Review>();

    public virtual ICollection<Review> ReviewUsers { get; set; } = new List<Review>();

    public virtual ICollection<UsersEvent> UsersEvents { get; set; } = new List<UsersEvent>();
}
